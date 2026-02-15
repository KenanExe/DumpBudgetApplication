namespace DumpBudgetApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            IncomeLabel = new Label();
            SQLExpensesTotalLabel = new Label();
            BtnIncomeAdd = new Button();
            BtnExpensesAdd = new Button();
            BtnIncomeList = new Button();
            BtnExpensesList = new Button();
            ExpensesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            SQLIncome2Label = new Label();
            SQLBudgetRemaninLabel = new Label();
            BudgetLabel = new Label();
            SQLBudgetAllocatedLabel = new Label();
            SQLIncomeTotalLabel = new Label();
            IncomePanel = new Panel();
            BudgetPanel = new Panel();
            ExpensesPanel = new Panel();
            SQLExpensesPendingLabel = new Label();
            ExpensesLabel = new Label();
            BudgetChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)ExpensesChart).BeginInit();
            IncomePanel.SuspendLayout();
            BudgetPanel.SuspendLayout();
            ExpensesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BudgetChart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 35);
            label1.Name = "label1";
            label1.Size = new Size(198, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome Dump Budget Application";
            // 
            // IncomeLabel
            // 
            IncomeLabel.AutoSize = true;
            IncomeLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            IncomeLabel.Location = new Point(3, 0);
            IncomeLabel.Name = "IncomeLabel";
            IncomeLabel.Size = new Size(53, 15);
            IncomeLabel.TabIndex = 1;
            IncomeLabel.Text = "INCOME";
            // 
            // SQLExpensesTotalLabel
            // 
            SQLExpensesTotalLabel.AutoSize = true;
            SQLExpensesTotalLabel.Location = new Point(3, 15);
            SQLExpensesTotalLabel.Name = "SQLExpensesTotalLabel";
            SQLExpensesTotalLabel.Size = new Size(128, 15);
            SQLExpensesTotalLabel.TabIndex = 6;
            SQLExpensesTotalLabel.Text = "Total Expenses: $00.000";
            // 
            // BtnIncomeAdd
            // 
            BtnIncomeAdd.Location = new Point(138, 303);
            BtnIncomeAdd.Name = "BtnIncomeAdd";
            BtnIncomeAdd.Size = new Size(107, 34);
            BtnIncomeAdd.TabIndex = 7;
            BtnIncomeAdd.Text = "Income Add";
            BtnIncomeAdd.UseVisualStyleBackColor = true;
            // 
            // BtnExpensesAdd
            // 
            BtnExpensesAdd.Location = new Point(371, 303);
            BtnExpensesAdd.Name = "BtnExpensesAdd";
            BtnExpensesAdd.Size = new Size(107, 34);
            BtnExpensesAdd.TabIndex = 9;
            BtnExpensesAdd.Text = "Expenses Add";
            BtnExpensesAdd.UseVisualStyleBackColor = true;
            // 
            // BtnIncomeList
            // 
            BtnIncomeList.Location = new Point(25, 303);
            BtnIncomeList.Name = "BtnIncomeList";
            BtnIncomeList.Size = new Size(107, 34);
            BtnIncomeList.TabIndex = 10;
            BtnIncomeList.Text = "Income List";
            BtnIncomeList.UseVisualStyleBackColor = true;
            // 
            // BtnExpensesList
            // 
            BtnExpensesList.Location = new Point(258, 303);
            BtnExpensesList.Name = "BtnExpensesList";
            BtnExpensesList.Size = new Size(107, 34);
            BtnExpensesList.TabIndex = 11;
            BtnExpensesList.Text = "Expenses List";
            BtnExpensesList.UseVisualStyleBackColor = true;
            BtnExpensesList.Click += BtnExpensesList_Click;
            // 
            // ExpensesChart
            // 
            chartArea1.Name = "ChartArea1";
            ExpensesChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = StringAlignment.Center;
            legend1.Name = "Legend1";
            ExpensesChart.Legends.Add(legend1);
            ExpensesChart.Location = new Point(258, 153);
            ExpensesChart.Name = "ExpensesChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Series1";
            ExpensesChart.Series.Add(series1);
            ExpensesChart.Size = new Size(220, 144);
            ExpensesChart.TabIndex = 12;
            ExpensesChart.Text = "chart1";
            // 
            // SQLIncome2Label
            // 
            SQLIncome2Label.AutoSize = true;
            SQLIncome2Label.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            SQLIncome2Label.ForeColor = Color.FromArgb(64, 64, 64);
            SQLIncome2Label.Location = new Point(3, 30);
            SQLIncome2Label.Name = "SQLIncome2Label";
            SQLIncome2Label.Size = new Size(103, 13);
            SQLIncome2Label.TabIndex = 5;
            SQLIncome2Label.Text = "Last Month: +$200";
            // 
            // SQLBudgetRemaninLabel
            // 
            SQLBudgetRemaninLabel.AutoSize = true;
            SQLBudgetRemaninLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            SQLBudgetRemaninLabel.ForeColor = Color.FromArgb(64, 64, 64);
            SQLBudgetRemaninLabel.Location = new Point(0, 30);
            SQLBudgetRemaninLabel.Name = "SQLBudgetRemaninLabel";
            SQLBudgetRemaninLabel.Size = new Size(89, 13);
            SQLBudgetRemaninLabel.TabIndex = 5;
            SQLBudgetRemaninLabel.Text = "Remaning: $200";
            // 
            // BudgetLabel
            // 
            BudgetLabel.AutoSize = true;
            BudgetLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BudgetLabel.Location = new Point(0, 0);
            BudgetLabel.Name = "BudgetLabel";
            BudgetLabel.Size = new Size(52, 15);
            BudgetLabel.TabIndex = 1;
            BudgetLabel.Text = "BUDGET";
            // 
            // SQLBudgetAllocatedLabel
            // 
            SQLBudgetAllocatedLabel.AutoSize = true;
            SQLBudgetAllocatedLabel.Location = new Point(0, 15);
            SQLBudgetAllocatedLabel.Name = "SQLBudgetAllocatedLabel";
            SQLBudgetAllocatedLabel.Size = new Size(108, 15);
            SQLBudgetAllocatedLabel.TabIndex = 4;
            SQLBudgetAllocatedLabel.Text = "Allocated: $000.000";
            // 
            // SQLIncomeTotalLabel
            // 
            SQLIncomeTotalLabel.AutoSize = true;
            SQLIncomeTotalLabel.Location = new Point(3, 15);
            SQLIncomeTotalLabel.Name = "SQLIncomeTotalLabel";
            SQLIncomeTotalLabel.Size = new Size(127, 15);
            SQLIncomeTotalLabel.TabIndex = 4;
            SQLIncomeTotalLabel.Text = "Total Income: $000.000";
            // 
            // IncomePanel
            // 
            IncomePanel.BackColor = Color.White;
            IncomePanel.BorderStyle = BorderStyle.FixedSingle;
            IncomePanel.Controls.Add(SQLIncome2Label);
            IncomePanel.Controls.Add(IncomeLabel);
            IncomePanel.Controls.Add(SQLIncomeTotalLabel);
            IncomePanel.Location = new Point(25, 95);
            IncomePanel.Name = "IncomePanel";
            IncomePanel.Size = new Size(147, 52);
            IncomePanel.TabIndex = 18;
            // 
            // BudgetPanel
            // 
            BudgetPanel.BackColor = Color.White;
            BudgetPanel.BorderStyle = BorderStyle.FixedSingle;
            BudgetPanel.Controls.Add(SQLBudgetRemaninLabel);
            BudgetPanel.Controls.Add(BudgetLabel);
            BudgetPanel.Controls.Add(SQLBudgetAllocatedLabel);
            BudgetPanel.Location = new Point(178, 95);
            BudgetPanel.Name = "BudgetPanel";
            BudgetPanel.Size = new Size(147, 52);
            BudgetPanel.TabIndex = 19;
            // 
            // ExpensesPanel
            // 
            ExpensesPanel.BackColor = Color.White;
            ExpensesPanel.BorderStyle = BorderStyle.FixedSingle;
            ExpensesPanel.Controls.Add(SQLExpensesPendingLabel);
            ExpensesPanel.Controls.Add(ExpensesLabel);
            ExpensesPanel.Controls.Add(SQLExpensesTotalLabel);
            ExpensesPanel.Location = new Point(331, 95);
            ExpensesPanel.Name = "ExpensesPanel";
            ExpensesPanel.Size = new Size(147, 52);
            ExpensesPanel.TabIndex = 20;
            // 
            // SQLExpensesPendingLabel
            // 
            SQLExpensesPendingLabel.AutoSize = true;
            SQLExpensesPendingLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            SQLExpensesPendingLabel.ForeColor = Color.FromArgb(64, 64, 64);
            SQLExpensesPendingLabel.Location = new Point(0, 30);
            SQLExpensesPendingLabel.Name = "SQLExpensesPendingLabel";
            SQLExpensesPendingLabel.Size = new Size(80, 13);
            SQLExpensesPendingLabel.TabIndex = 5;
            SQLExpensesPendingLabel.Text = "Pending: $200";
            // 
            // ExpensesLabel
            // 
            ExpensesLabel.AutoSize = true;
            ExpensesLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ExpensesLabel.Location = new Point(0, 0);
            ExpensesLabel.Name = "ExpensesLabel";
            ExpensesLabel.Size = new Size(62, 15);
            ExpensesLabel.TabIndex = 1;
            ExpensesLabel.Text = "EXPENSES";
            // 
            // BudgetChart
            // 
            chartArea2.Name = "ChartArea1";
            BudgetChart.ChartAreas.Add(chartArea2);
            legend2.Alignment = StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            legend2.TitleFont = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BudgetChart.Legends.Add(legend2);
            BudgetChart.Location = new Point(25, 153);
            BudgetChart.Name = "BudgetChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            BudgetChart.Series.Add(series2);
            BudgetChart.Size = new Size(220, 144);
            BudgetChart.TabIndex = 21;
            BudgetChart.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 362);
            Controls.Add(BudgetChart);
            Controls.Add(ExpensesPanel);
            Controls.Add(BudgetPanel);
            Controls.Add(IncomePanel);
            Controls.Add(ExpensesChart);
            Controls.Add(BtnExpensesList);
            Controls.Add(BtnIncomeList);
            Controls.Add(BtnExpensesAdd);
            Controls.Add(BtnIncomeAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ExpensesChart).EndInit();
            IncomePanel.ResumeLayout(false);
            IncomePanel.PerformLayout();
            BudgetPanel.ResumeLayout(false);
            BudgetPanel.PerformLayout();
            ExpensesPanel.ResumeLayout(false);
            ExpensesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BudgetChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label IncomeLabel;
        private Label SQLExpensesTotalLabel;
        private Button BtnIncomeAdd;
        private Button BtnExpensesAdd;
        private Button BtnIncomeList;
        private Button BtnExpensesList;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExpensesChart;
        private Label SQLIncome2Label;
        private Label SQLBudgetRemaninLabel;
        private Label BudgetLabel;
        private Label SQLBudgetAllocatedLabel;
        private Label SQLIncomeTotalLabel;
        private Panel IncomePanel;
        private Panel BudgetPanel;
        private Panel ExpensesPanel;
        private Label SQLExpensesPendingLabel;
        private Label ExpensesLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart BudgetChart;
    }
}
