
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
        private void Task3_Click(object sender, EventArgs e)
        {
            HWTask3 task3 = new HWTask3();
            task3.ShowDialog();
        }
        private void Task4_Click(object sender, EventArgs e)
        {
            HWTask4 task4 = new HWTask4();
            task4.ShowDialog();
        }
        private void Task5_Click(object sender, EventArgs e)
        {
            HWTask5 task5 = new HWTask5();
            task5.ShowDialog();
        }
    }
}
