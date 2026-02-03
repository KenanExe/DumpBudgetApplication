using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace DumpBudgetApplication
{
    public partial class BudgetList : Form
    {
        public BudgetList()
        {
            InitializeComponent();
        }

        private void BudgetList_Load(object sender, EventArgs e)
        {
        LoadCategoryItems();
        LoadItems();
        }
        void LoadItems()
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=DBADataBase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = $@"
                         SELECT c.Name AS category, t.price, t.description
                         FROM tableitems t
                         INNER JOIN categorylist c
                         ON t.Category = c.Category
                         where 1 = 1
";
            if (!string.IsNullOrEmpty(ComboCategory.Text))
            {sql += $@" and c.Category =  {ComboCategory.SelectedIndex + 1}";}
            if (UpDownBox.Value > 0)
            { sql += $@" and t.price like  '%{UpDownBox.Value}%'"; }
            if (!string.IsNullOrEmpty(TBDescription.Text))
            { sql += $@" and t.description like  '%{TBDescription.Text}%'"; }


            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<ItemsDTO> items = new List<ItemsDTO>();
            while (reader.Read())
            {
                ItemsDTO item = new ItemsDTO();
                item.Category = reader["category"].ToString();
                item.Price = Convert.ToDouble(reader["price"]);
                item.Description = reader["description"].ToString();
                items.Add(item);
            }
            DataViewGrid.DataSource = items;
            m_dbConnection.Close();
        }
        void LoadCategoryItems()
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=DBADataBase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = @"
                         SELECT Category, Name, Description from categorylist
                         ";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<CategoryDTO> itemcs = new List<CategoryDTO>();
            while (reader.Read())
            {
                CategoryDTO itemc = new CategoryDTO();
                itemc.Category = Convert.ToInt16(reader["Category"]);
                itemc.Name = reader["Name"].ToString();
                ComboCategory.Items.Add(itemc.Name);
                itemc.Description = reader["Description"].ToString();
                itemcs.Add(itemc);
            }
            m_dbConnection.Close();
        }

        class ItemsDTO
            {
            public string Category { get; set; }
            public double Price { get; set; }
            public string Description { get; set; }
        }
        class CategoryDTO
        {
            public int Category { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
        void combocategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItems();
        }

        void clean(object sender, EventArgs e)
        {
            ComboCategory.Text = string.Empty;
            UpDownBox.Value = 0;
            TBDescription.Text = string.Empty;
            LoadItems();
        }

    }
}
