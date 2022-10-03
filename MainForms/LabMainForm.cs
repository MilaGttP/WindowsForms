
namespace WindowsForms
{
    public partial class LabMainForm : Form
    {
        public LabMainForm()
        {
            InitializeComponent();
        }
        private void Task1_Click(object sender, EventArgs e)
        {
            LabTask1 labTask1 = new LabTask1();
            labTask1.ShowDialog();
        }
        private void Task2_Click(object sender, EventArgs e)
        {
            LabTask2 labTask2 = new LabTask2();
            labTask2.ShowDialog();
        }
        private void Task3_Click(object sender, EventArgs e)
        {
            LabTask3 labTask3 = new LabTask3();
            labTask3.ShowDialog();
        }
    }
}
