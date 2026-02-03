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
            label4.Location = new Point(313, 106);
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
            SQLExpensesLabel.Location = new Point(299, 136);
            SQLExpensesLabel.Name = "SQLExpensesLabel";
            SQLExpensesLabel.Size = new Size(78, 15);
            SQLExpensesLabel.TabIndex = 6;
            SQLExpensesLabel.Text = "SQL.Expenses";
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
            BtnExpensesAdd.Location = new Point(289, 303);
            BtnExpensesAdd.Name = "BtnExpensesAdd";
            BtnExpensesAdd.Size = new Size(107, 34);
            BtnExpensesAdd.TabIndex = 9;
            BtnExpensesAdd.Text = "Expenses Add";
            BtnExpensesAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 349);
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
    }
}
