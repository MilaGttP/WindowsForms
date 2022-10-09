
namespace WindowsForms
{
    public partial class HWMainForm : Form
    {
        public HWMainForm()
        {
            InitializeComponent();
        }

        private void Task1_Click(object sender, EventArgs e)
        {
            HWTask1 task1 = new HWTask1();
            task1.ShowDialog();
            this.DialogResult = DialogResult.Cancel;
        }
        private void Task2_Click(object sender, EventArgs e)
        {
            PersonListForm task2 = new PersonListForm();
            task2.ShowDialog();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
