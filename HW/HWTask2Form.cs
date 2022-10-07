
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection.Emit;

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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int dateC; string DateC;
            DateC = Convert.ToString(((dateTimePicker1.Value - dateTimePicker2.Value).Days));
            if ((dateC = Convert.ToInt32(DateC)) > 0) ResLabel.Text = "Days between dates is " + DateC;
            else ResLabel.Text = "Days between dates is " + Convert.ToString(Math.Abs(dateC) + 1);
        }
    }
}
