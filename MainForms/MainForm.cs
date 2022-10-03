
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
            LabMainForm labMainForm = new LabMainForm();
            labMainForm.ShowDialog();
        }
        private void HWButton_Click(object sender, EventArgs e)
        {
            HWMainForm hWMainForm = new HWMainForm();
            hWMainForm.ShowDialog();
        }
    }
}