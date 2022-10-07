
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsForms
{
    public partial class HWTask2Form : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public HWTask2Form()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, this.Width, this.Height));
            panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, panel.Width, panel.Height));
        }

        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();
    }
}
