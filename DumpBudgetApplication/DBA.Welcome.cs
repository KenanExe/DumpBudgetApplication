namespace DumpBudgetApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBudgetList_Click(object sender, EventArgs e)
        {
            OpenForm<BudgetList>();
        }
        private void OpenForm<T>() where T : Form, new()
        {
            T form = new T();
            form.Show();
        }
    }
}
