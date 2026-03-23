using System.Data.SQLite;
namespace DumpBudgetApplication
{
    public partial class ExpensesList : Form
    {
        int pageSize = 10;
        int page = 0;
        int listCount = 0;
        int uplimitData = 0;
        bool canUp = true;
        bool canDown = false;

        public ExpensesList()
        {
            InitializeComponent();
            DataViewGrid.MouseWheel += DataViewGrid_MouseWheel;
        }


        private void BudgetList_Load(object sender, EventArgs e)
        {
            ComboOrderby.SelectedIndex = 0;
            LoadCategoryItems();
            LoadItems();
        }



        void CountDatas()
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=DBADataBase.sqlite;Version=3;");
            m_dbConnection.Open();
            string sql = "SELECT COUNT(*) AS Total FROM tblexpenses";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lbCount.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("Total")) + " Total items found. Showing " +Convert.ToString(listCount)+" items.");
            }
            m_dbConnection.Close();
        }
        void LoadItems()
        {
            uplimitData = page * pageSize;

            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=DBADataBase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = $@"
                         SELECT c.Name AS category, t.price, t.description
                         FROM tblexpenses t
                         INNER JOIN categorylist c
                         ON t.Category = c.Category
                         where 1 = 1
";
            if (!string.IsNullOrEmpty(ComboCategory.Text))
            { sql += $@" and c.Category =  {ComboCategory.SelectedIndex + 1}"; }
            if (UpDownBox.Value > 0)
            { sql += $@" and t.price like  '%{UpDownBox.Value}%'"; }

            
            if (ComboOrderby.SelectedIndex == 0)
            { sql += $@" ORDER BY t.price DESC"; }
            if (ComboOrderby.SelectedIndex == 1)
            { sql += $@" ORDER BY t.price ASC"; }

            sql += $@" LIMIT {pageSize} OFFSET {uplimitData}";


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
            listCount = items.Count;
            m_dbConnection.Close();
            CountDatas();
            CheckButtons();
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
                ComboCategory.Items.Add(itemc);
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
        }

        void combocategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            page = 0;
            LoadItems();
        }

        void clean(object sender, EventArgs e)
        {
            ComboCategory.Text = string.Empty;
            UpDownBox.Value = 0;
            page = 0;
            //TBDescription.Text = string.Empty;

            DataViewGrid.DataSource = null;
            DataViewGrid.Rows.Clear();
            DataViewGrid.Refresh();
            LoadItems();
        }

        private void LabelDescription_Click(object sender, EventArgs e)
        {

        }
        void CheckButtons()
        {
            if (page > 0)
            {
                canDown = true;
            }
            if (page <= 0)
            {
                canDown = false;
            }

            if (pageSize <= listCount )
            {
                canUp = true;
            }
            if (pageSize > listCount)
            {
                canUp = false;
            }

            if (canDown)
            {
                btnDown.Enabled = true;
            } else
            {
                btnDown.Enabled = false;
            }

            if (canUp)
            {
                btnUp.Enabled = true;
            }
            else
            {
                btnUp.Enabled = false;
            }

        }

        private void PageUp(object sender, EventArgs e)
        {
            CheckButtons();
            if (canUp)
            {
            page++;
            LoadItems();
            }
        }
        private void PageDown(object sender, EventArgs e)
        {
            CheckButtons();
            if (canDown)
            {
                page--;
                LoadItems();
            }
        }

        private void DataViewGrid_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                btnUp.PerformClick();
            }
            if (e.Delta > 0)
            {
                btnDown.PerformClick();
            }
        }

    }
}
