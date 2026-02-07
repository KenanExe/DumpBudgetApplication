using System;
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
            CenterControls();
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


            ExpensesChart.Series.Clear();
            Series s = new Series("itemsExpenses");
            s.ChartType = SeriesChartType.Doughnut;
            s["PieLabelStyle"] = "Disabled";

            BudgetChart.Series.Clear();
            BudgetChart.ChartAreas.Clear();
            BudgetChart.Legends.Clear();

            ChartArea area = new ChartArea();
            BudgetChart.ChartAreas.Add(area);

            Legend legend = new Legend();
            BudgetChart.Legends.Add(legend);

            Series Income = new Series("Income");
            Income.ChartType = SeriesChartType.Column;
            Income.Color = Color.DodgerBlue;
            Income.IsValueShownAsLabel = true;

            Series Expsenses = new Series("Expsenses");
            Expsenses.ChartType = SeriesChartType.Column;
            Expsenses.Color = Color.IndianRed;
            Expsenses.IsValueShownAsLabel = true;

            BudgetChart.Series.Add(Income);
            BudgetChart.Series.Add(Expsenses);




            while (reader.Read())
            {
                expsenseDTO item = new expsenseDTO();
                item.Category = reader["CategoryName"].ToString();
                item.TotalExpense = Convert.ToDouble(reader["TotalExpense"]);
                items.Add(item);
                s.Points.Add(new DataPoint() { YValues = new double[] { item.TotalExpense }, Label = item.Category });
            }
            SQLExpensesTotalLabel.Text = $"Total Expenses: ${items.Sum(x => x.TotalExpense)}";
            ExpensesChart.Series.Add(s);
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

        private void CenterControls()
        {
            IncomePanel_Center();
            BudgetePanel_Center();
            ExpensesPanel_Center();
        }

        private void IncomePanel_Center()
        {
            IncomeLabel.Left = (IncomePanel.ClientSize.Width - IncomeLabel.Width) / 2;
            SQLIncomeTotalLabel.Left = (IncomePanel.ClientSize.Width - SQLIncomeTotalLabel.Width) / 2;
            SQLIncome2Label.Left = (IncomePanel.ClientSize.Width - SQLIncome2Label.Width) / 2;

        }
        private void BudgetePanel_Center()
        {
            BudgetLabel.Left = (BudgetPanel.ClientSize.Width - IncomeLabel.Width) / 2;
            SQLBudgetAllocatedLabel.Left = (BudgetPanel.ClientSize.Width - SQLBudgetAllocatedLabel.Width) / 2;
            SQLBudgetRemaninLabel.Left = (BudgetPanel.ClientSize.Width - SQLBudgetRemaninLabel.Width) / 2;

        }
        private void ExpensesPanel_Center()
        {
            ExpensesLabel.Left = (ExpensesPanel.ClientSize.Width - ExpensesLabel.Width) / 2;
            SQLExpensesPendingLabel.Left = (ExpensesPanel.ClientSize.Width - SQLExpensesPendingLabel.Width) / 2;
            SQLExpensesTotalLabel.Left = (ExpensesPanel.ClientSize.Width - SQLExpensesTotalLabel.Width) / 2;

        }

    }
}
