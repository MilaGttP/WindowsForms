
namespace WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();
        private void SelectedIndexLabTabControl(object sender, EventArgs e)
        {
            if (LabTabControl.SelectedIndex == 0) this.Text = "MainForm";
            else if (LabTabControl.SelectedIndex == 1) this.Text = "Яка усмішка вам до душі?";
        }
        
        public string path { get; set; } = "";
        private void SelectedIndexHWTabControl(object sender, EventArgs e)
        {
            if (HWTabControl.SelectedIndex == 0)
            {
                
            }
        }
    }
}
