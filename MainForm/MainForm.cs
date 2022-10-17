
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
        private void SelectedIndexHWTabControl(object sender, EventArgs e)
        {
            if (HWTabControl.SelectedIndex == 1)
            {
                pathForExp = new List <string> ();
                this.Text = "Explorer";
                SearchDrives();
                this.ContextMenuStrip = this.contextMenuForExplorer;
                BackToolStripForExp.Click += BackToolExp_Click;
                OpenContextForExp.Click += OpenToolForExp_Click;
                BackContextForExp.Click += BackToolExp_Click;
            }
        }
    }
}
