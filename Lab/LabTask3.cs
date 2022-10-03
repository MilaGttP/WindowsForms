
namespace WindowsForms
{
    public partial class LabTask3 : Form
    {
        public LabTask3()
        {
            InitializeComponent();
            this.MouseMove += MoveMouse;
            this.MouseClick += ClickMouse;
        }
        private void ClickMouse(object sender, MouseEventArgs e)
        {
            string valueToShow = "";
            if (e.Button == MouseButtons.Right)
            {
                Text = $" Size of client`s window area => Width = {ClientSize.Width}, Height = {ClientSize.Height}";
                Thread.Sleep(2000);
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (ModifierKeys == Keys.Control) Close();
                if ((e.X < 10 || e.X > ClientSize.Width - 10) || (e.Y < 10 || e.Y > ClientSize.Height - 10))
                    valueToShow = "Click outside of the rectangle!";
                else if ((e.X == 10 || e.X == ClientSize.Width - 10) || (e.Y == 10 || e.Y == ClientSize.Height - 10))
                    valueToShow = "Click on the border of the rectangle!";
                else valueToShow = "Click inside of the rectangle!";
                MessageBox.Show(valueToShow, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void MoveMouse(object sender, MouseEventArgs e) => Text = $" X {e.X} - Y {e.Y}";
    }
}
