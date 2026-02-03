namespace DumpBudgetApplication
{
    partial class BudgetList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataViewGrid = new DataGridView();
            ComboCategory = new ComboBox();
            LabelCategory = new Label();
            LabelPrice = new Label();
            LabelItem = new Label();
            BtnAddExpenses = new Button();
            TBDescription = new TextBox();
            LabelDescription = new Label();
            BtnClear = new Button();
            UpDownBox = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)DataViewGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownBox).BeginInit();
            SuspendLayout();
            // 
            // DataViewGrid
            // 
            DataViewGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataViewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataViewGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataViewGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataViewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataViewGrid.Location = new Point(10, 62);
            DataViewGrid.Name = "DataViewGrid";
            DataViewGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataViewGrid.Size = new Size(509, 353);
            DataViewGrid.TabIndex = 0;
            // 
            // ComboCategory
            // 
            ComboCategory.FormattingEnabled = true;
            ComboCategory.Location = new Point(10, 33);
            ComboCategory.Name = "ComboCategory";
            ComboCategory.Size = new Size(97, 23);
            ComboCategory.TabIndex = 1;
            ComboCategory.SelectedIndexChanged += combocategory_SelectedIndexChanged;
            // 
            // LabelCategory
            // 
            LabelCategory.AutoSize = true;
            LabelCategory.Location = new Point(27, 12);
            LabelCategory.Name = "LabelCategory";
            LabelCategory.Size = new Size(55, 15);
            LabelCategory.TabIndex = 4;
            LabelCategory.Text = "Category";
            // 
            // LabelPrice
            // 
            LabelPrice.AutoSize = true;
            LabelPrice.Location = new Point(143, 12);
            LabelPrice.Name = "LabelPrice";
            LabelPrice.Size = new Size(33, 15);
            LabelPrice.TabIndex = 5;
            LabelPrice.Text = "Price";
            // 
            // LabelItem
            // 
            LabelItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelItem.Location = new Point(10, 422);
            LabelItem.Name = "LabelItem";
            LabelItem.Size = new Size(58, 15);
            LabelItem.TabIndex = 7;
            LabelItem.Text = "0000 Item";
            // 
            // BtnAddExpenses
            // 
            BtnAddExpenses.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAddExpenses.Location = new Point(427, 418);
            BtnAddExpenses.Name = "BtnAddExpenses";
            BtnAddExpenses.Size = new Size(92, 23);
            BtnAddExpenses.TabIndex = 8;
            BtnAddExpenses.Text = "Add Expenses";
            BtnAddExpenses.UseVisualStyleBackColor = true;
            // 
            // TBDescription
            // 
            TBDescription.Location = new Point(219, 33);
            TBDescription.Name = "TBDescription";
            TBDescription.Size = new Size(100, 23);
            TBDescription.TabIndex = 10;
            TBDescription.TextChanged += combocategory_SelectedIndexChanged;
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.Location = new Point(233, 15);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(67, 15);
            LabelDescription.TabIndex = 11;
            LabelDescription.Text = "Description";
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(325, 32);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 23);
            BtnClear.TabIndex = 12;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += clean;
            // 
            // UpDownBox
            // 
            UpDownBox.Location = new Point(113, 33);
            UpDownBox.Name = "UpDownBox";
            UpDownBox.Size = new Size(100, 23);
            UpDownBox.TabIndex = 13;
            UpDownBox.ValueChanged += combocategory_SelectedIndexChanged;
            // 
            // BudgetList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 442);
            Controls.Add(UpDownBox);
            Controls.Add(BtnClear);
            Controls.Add(LabelDescription);
            Controls.Add(TBDescription);
            Controls.Add(BtnAddExpenses);
            Controls.Add(LabelItem);
            Controls.Add(LabelPrice);
            Controls.Add(LabelCategory);
            Controls.Add(ComboCategory);
            Controls.Add(DataViewGrid);
            Name = "BudgetList";
            Text = "BudgetList";
            Load += BudgetList_Load;
            ((System.ComponentModel.ISupportInitialize)DataViewGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataViewGrid;
        private ComboBox ComboCategory;
        private Label LabelCategory;
        private Label LabelPrice;
        private Label LabelItem;
        private Button BtnAddExpenses;
        private TextBox TBDescription;
        private Label LabelDescription;
        private Button BtnClear;
        private NumericUpDown UpDownBox;
    }
}