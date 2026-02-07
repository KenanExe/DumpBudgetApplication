using System.Data.SQLite;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
namespace DumpBudgetApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ExpensesChartData();
        }

        private void BtnBudgetList_Click(object sender, EventArgs e)
        {

        }

        private void BtnExpensesList_Click(object sender, EventArgs e)
        {
            OpenForm<ExpensesList>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        void ExpensesChartData()
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=DBADataBase.sqlite;Version=3;");
            m_dbConnection.Open();

            var sql2 = @"
        WITH RankedExpenses AS (
        SELECT 
        CAST(c.Name AS VARCHAR(100)) AS CategoryName,
        SUM(e.Price) AS TotalExpense,
        RANK() OVER (ORDER BY SUM(e.Price) DESC) AS rn
        FROM tblexpenses e
        INNER JOIN Categorylist c
        ON e.Category = c.Category
        GROUP BY CAST(c.Name AS VARCHAR(100)))
        SELECT 
        CASE 
        WHEN rn <= 3 THEN CategoryName
        ELSE 'Other'
        END AS CategoryName,
        SUM(TotalExpense) AS TotalExpense
        FROM RankedExpenses
        GROUP BY 
        CASE 
        WHEN rn <= 3 THEN CategoryName
        ELSE 'Other'
        END
        ORDER BY TotalExpense DESC;
        ";
            SQLiteCommand command = new SQLiteCommand(sql2, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<expsenseDTO> items = new List<expsenseDTO>();


            chart1.Series.Clear();
            Series s = new Series("itemsExpenses");
            s.ChartType = SeriesChartType.Pyramid;
            s["PyramidLabelStyle"] = "Inside";


            while (reader.Read())
            {
                expsenseDTO item = new expsenseDTO();
                item.Category = reader["CategoryName"].ToString();
                item.TotalExpense = Convert.ToDouble(reader["TotalExpense"]);
                items.Add(item);
            s.Points.Add(new DataPoint() { YValues = new double[] { item.TotalExpense }, Label = item.Category });
            }
            SQLExpensesLabel.Text = $"Total Expenses: {items.Sum(x => x.TotalExpense)}$";
            chart1.Series.Add(s);
            m_dbConnection.Close();
        }
        class expsenseDTO
        {
            public string Category { get; set; }
            public double TotalExpense { get; set; }
        }

        private void OpenForm<T>() where T : Form, new()
        {
            T form = new T();
            form.Show();
        }
    }
}
