namespace DumpBudgetApplication
{
    partial class ExpensesList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataViewGrid = new DataGridView();
            ComboCategory = new ComboBox();
            LabelCategory = new Label();
            LabelPrice = new Label();
            lbCount = new Label();
            BtnAddExpenses = new Button();
            LabelDate = new Label();
            BtnClear = new Button();
            UpDownBox = new NumericUpDown();
            ComboOrderby = new ComboBox();
            LableOrderBy = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnUp = new Button();
            btnDown = new Button();
            ((System.ComponentModel.ISupportInitialize)DataViewGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownBox).BeginInit();
            SuspendLayout();
            // 
            // DataViewGrid
            // 
            DataViewGrid.AllowUserToAddRows = false;
            DataViewGrid.AllowUserToDeleteRows = false;
            DataViewGrid.AllowUserToResizeColumns = false;
            DataViewGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataViewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataViewGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataViewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataViewGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataViewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataViewGrid.DefaultCellStyle = dataGridViewCellStyle2;
            DataViewGrid.Location = new Point(10, 62);
            DataViewGrid.Name = "DataViewGrid";
            DataViewGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataViewGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DataViewGrid.Size = new Size(496, 352);
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
            // lbCount
            // 
            lbCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbCount.Location = new Point(10, 421);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(377, 19);
            lbCount.TabIndex = 7;
            lbCount.Text = "0000 Item";
            // 
            // BtnAddExpenses
            // 
            BtnAddExpenses.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAddExpenses.Location = new Point(414, 417);
            BtnAddExpenses.Name = "BtnAddExpenses";
            BtnAddExpenses.Size = new Size(92, 23);
            BtnAddExpenses.TabIndex = 8;
            BtnAddExpenses.Text = "Add Expenses";
            BtnAddExpenses.UseVisualStyleBackColor = true;
            // 
            // LabelDate
            // 
            LabelDate.AutoSize = true;
            LabelDate.Location = new Point(358, 16);
            LabelDate.Name = "LabelDate";
            LabelDate.Size = new Size(31, 15);
            LabelDate.TabIndex = 11;
            LabelDate.Text = "Date";
            LabelDate.Click += LabelDescription_Click;
            // 
            // BtnClear
            // 
            BtnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClear.Location = new Point(431, 34);
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
            // ComboOrderby
            // 
            ComboOrderby.FormattingEnabled = true;
            ComboOrderby.Items.AddRange(new object[] { "Hight to Low", "Low to Hight" });
            ComboOrderby.Location = new Point(219, 34);
            ComboOrderby.Name = "ComboOrderby";
            ComboOrderby.Size = new Size(100, 23);
            ComboOrderby.TabIndex = 14;
            ComboOrderby.TextChanged += combocategory_SelectedIndexChanged;
            // 
            // LableOrderBy
            // 
            LableOrderBy.AutoSize = true;
            LableOrderBy.Location = new Point(237, 16);
            LableOrderBy.Name = "LableOrderBy";
            LableOrderBy.Size = new Size(53, 15);
            LableOrderBy.TabIndex = 15;
            LableOrderBy.Text = "Order By";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(325, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // btnUp
            // 
            btnUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUp.Location = new Point(376, 417);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(32, 23);
            btnUp.TabIndex = 17;
            btnUp.Text = ">>";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += PageUp;
            // 
            // btnDown
            // 
            btnDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDown.Location = new Point(339, 417);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(32, 23);
            btnDown.TabIndex = 18;
            btnDown.Text = "<<";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += PageDown;
            // 
            // ExpensesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 441);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(dateTimePicker1);
            Controls.Add(LableOrderBy);
            Controls.Add(ComboOrderby);
            Controls.Add(UpDownBox);
            Controls.Add(BtnClear);
            Controls.Add(LabelDate);
            Controls.Add(BtnAddExpenses);
            Controls.Add(lbCount);
            Controls.Add(LabelPrice);
            Controls.Add(LabelCategory);
            Controls.Add(ComboCategory);
            Controls.Add(DataViewGrid);
            MinimumSize = new Size(526, 180);
            Name = "ExpensesList";
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
        private Label lbCount;
        private Button BtnAddExpenses;
        private TextBox TBDescription;
        private Label LabelDate;
        private Button BtnClear;
        private NumericUpDown UpDownBox;
        private ComboBox ComboOrderby;
        private Label LableOrderBy;
        private DateTimePicker dateTimePicker1;
        private Button btnUp;
        private Button btnDown;
    }
}