
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
        }
        private void Task2_Click(object sender, EventArgs e)
        {
            HWTask2 task2 = new HWTask2();
            task2.ShowDialog();
        }
    }
}
