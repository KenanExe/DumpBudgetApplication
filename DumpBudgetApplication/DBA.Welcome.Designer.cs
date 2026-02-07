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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SQLIncomeLabel = new Label();
            SQLBudgetLabel = new Label();
            SQLExpensesLabel = new Label();
            BtnIncomeAdd = new Button();
            BtnBudgetList = new Button();
            BtnExpensesAdd = new Button();
            BtnIncomeList = new Button();
            BtnExpensesList = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 106);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Income";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 106);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Budget";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 80);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Expenses";
            // 
            // SQLIncomeLabel
            // 
            SQLIncomeLabel.AutoSize = true;
            SQLIncomeLabel.Location = new Point(44, 136);
            SQLIncomeLabel.Name = "SQLIncomeLabel";
            SQLIncomeLabel.Size = new Size(71, 15);
            SQLIncomeLabel.TabIndex = 4;
            SQLIncomeLabel.Text = "SQL.Income";
            // 
            // SQLBudgetLabel
            // 
            SQLBudgetLabel.AutoSize = true;
            SQLBudgetLabel.Location = new Point(173, 136);
            SQLBudgetLabel.Name = "SQLBudgetLabel";
            SQLBudgetLabel.Size = new Size(69, 15);
            SQLBudgetLabel.TabIndex = 5;
            SQLBudgetLabel.Text = "SQL.Budget";
            // 
            // SQLExpensesLabel
            // 
            SQLExpensesLabel.AutoSize = true;
            SQLExpensesLabel.Location = new Point(332, 105);
            SQLExpensesLabel.Name = "SQLExpensesLabel";
            SQLExpensesLabel.Size = new Size(119, 15);
            SQLExpensesLabel.TabIndex = 6;
            SQLExpensesLabel.Text = "Total Expenses: 00000";
            // 
            // BtnIncomeAdd
            // 
            BtnIncomeAdd.Location = new Point(25, 303);
            BtnIncomeAdd.Name = "BtnIncomeAdd";
            BtnIncomeAdd.Size = new Size(107, 34);
            BtnIncomeAdd.TabIndex = 7;
            BtnIncomeAdd.Text = "Income Add";
            BtnIncomeAdd.UseVisualStyleBackColor = true;
            // 
            // BtnBudgetList
            // 
            BtnBudgetList.Location = new Point(154, 303);
            BtnBudgetList.Name = "BtnBudgetList";
            BtnBudgetList.Size = new Size(107, 34);
            BtnBudgetList.TabIndex = 8;
            BtnBudgetList.Text = "Budget List";
            BtnBudgetList.UseVisualStyleBackColor = true;
            BtnBudgetList.Click += BtnBudgetList_Click;
            // 
            // BtnExpensesAdd
            // 
            BtnExpensesAdd.Location = new Point(344, 303);
            BtnExpensesAdd.Name = "BtnExpensesAdd";
            BtnExpensesAdd.Size = new Size(107, 34);
            BtnExpensesAdd.TabIndex = 9;
            BtnExpensesAdd.Text = "Expenses Add";
            BtnExpensesAdd.UseVisualStyleBackColor = true;
            // 
            // BtnIncomeList
            // 
            BtnIncomeList.Location = new Point(25, 263);
            BtnIncomeList.Name = "BtnIncomeList";
            BtnIncomeList.Size = new Size(107, 34);
            BtnIncomeList.TabIndex = 10;
            BtnIncomeList.Text = "Income List";
            BtnIncomeList.UseVisualStyleBackColor = true;
            // 
            // BtnExpensesList
            // 
            BtnExpensesList.Location = new Point(344, 263);
            BtnExpensesList.Name = "BtnExpensesList";
            BtnExpensesList.Size = new Size(107, 34);
            BtnExpensesList.TabIndex = 11;
            BtnExpensesList.Text = "Expenses List";
            BtnExpensesList.UseVisualStyleBackColor = true;
            BtnExpensesList.Click += BtnExpensesList_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(320, 123);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(148, 134);
            chart1.TabIndex = 12;
            chart1.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 362);
            Controls.Add(chart1);
            Controls.Add(BtnExpensesList);
            Controls.Add(BtnIncomeList);
            Controls.Add(BtnExpensesAdd);
            Controls.Add(BtnBudgetList);
            Controls.Add(BtnIncomeAdd);
            Controls.Add(SQLExpensesLabel);
            Controls.Add(SQLBudgetLabel);
            Controls.Add(SQLIncomeLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label SQLIncomeLabel;
        private Label SQLBudgetLabel;
        private Label SQLExpensesLabel;
        private Button BtnIncomeAdd;
        private Button BtnBudgetList;
        private Button BtnExpensesAdd;
        private Button BtnIncomeList;
        private Button BtnExpensesList;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
