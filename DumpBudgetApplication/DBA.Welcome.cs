using System;
using System.Data.SQLite;
using System.Globalization;
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
    INNER JOIN Categorylist c ON e.Category = c.Category
    GROUP BY CAST(c.Name AS VARCHAR(100))
),
CategoryData AS (
    SELECT 
        CASE 
            WHEN rn <= 8 THEN CategoryName
            ELSE 'Other'
        END AS CategoryName,
        SUM(TotalExpense) AS TotalExpense
    FROM RankedExpenses
    GROUP BY 
        CASE 
            WHEN rn <= 8 THEN CategoryName
            ELSE 'Other'
        END
),
MonthlyData AS (
    SELECT 
        strftime('%Y-%m', date(substr(date, 7, 4) || '-' || substr(date, 4, 2) || '-' || substr(date, 1, 2))) as YearMonth,
        SUM(Price) as TotalExpense
    FROM tblexpenses
    WHERE date IS NOT NULL AND date != ''
    GROUP BY YearMonth
    ORDER BY YearMonth DESC
    LIMIT 12
)
SELECT 'Category' as DataType, CategoryName, TotalExpense, NULL as YearMonth 
FROM CategoryData
UNION ALL
SELECT 'Monthly' as DataType, NULL as CategoryName, TotalExpense, YearMonth 
FROM MonthlyData
ORDER BY DataType DESC, YearMonth ASC;
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
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.Interval = 1;
            //area.AxisX.LabelStyle.Font = new Font("Arial", 8);

            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            BudgetChart.ChartAreas.Add(area);
            area.AxisY.LabelStyle.Format = "N0";
            area.AxisY.LabelStyle.Font = new Font("Arial", 8);

            Legend legend = new Legend();
            legend.Docking = Docking.Top;
            legend.Font = new Font("Arial", 8);
            BudgetChart.Legends.Add(legend);


            Series Expsenses = new Series("Expenses");
            Expsenses.ChartType = SeriesChartType.Column;
            Expsenses.Color = Color.IndianRed;

            BudgetChart.Series.Add(Expsenses);
            int monthIndex = 0;
            while (reader.Read())
            {
                string dataType = reader["DataType"].ToString();

                if (dataType == "Category")
                {
                    expsenseDTO item = new expsenseDTO();
                    item.Category = reader["CategoryName"].ToString();
                    item.TotalExpense = Convert.ToDouble(reader["TotalExpense"]);
                    items.Add(item);
                    s.Points.Add(new DataPoint() { YValues = new double[] { item.TotalExpense }, Label = item.Category });
                }
                else if (dataType == "Monthly")
                {
                    string yearMonth = reader["YearMonth"].ToString();
                    double totalExpense = Convert.ToDouble(reader["TotalExpense"]);

                    DateTime dt = DateTime.ParseExact(yearMonth + "-01", "yyyy-MM-dd", null);
                    string monthLabel = dt.ToString("MMM yy", new System.Globalization.CultureInfo("en-US"));

                    int pointIndex = Expsenses.Points.AddXY(monthIndex, totalExpense);
                    Expsenses.Points[pointIndex].AxisLabel = monthLabel;
                    //Expsenses.Points[pointIndex].Label = totalExpense.ToString("C0"); // Price on top
                    monthIndex++;
                }
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
