namespace WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void LabButton_Click(object sender, EventArgs e)
        {
            LabTask labTask = new LabTask();
            labTask.ShowDialog();
        }
        private void HWButton_Click(object sender, EventArgs e)
        {
            HWMainForm hwMainForm = new HWMainForm();
            hwMainForm.ShowDialog();
        }
    }
}