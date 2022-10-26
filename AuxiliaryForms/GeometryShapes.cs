
namespace WindowsForms
{
    public partial class GeometryShapes : Form
    {
        Color color = Color.Black;
        int width = 0;
        int height = 0;

        public GeometryShapes() => InitializeComponent();
        private void ColorTool_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK) color = dialog.Color;
        }
        private void WidthTB_TextChanged(object sender, EventArgs e) => width = Convert.ToInt32(WidthTB.Text);
        private void HeightTB_TextChanged(object sender, EventArgs e) => height = Convert.ToInt32(HeightTB.Text);
        private void Ellipse_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(color, 5);
            Graphics g = CreateGraphics();
            if (width > 640 || height > 520) MessageBox.Show("Ellipse`s parameters more than workout panel!", "Error!");
            else
            {
                if (width != 0 || height != 0) g.DrawEllipse(pn, 50, 50, width, height);
                else g.DrawEllipse(pn, 50, 50, 100, 100);
            }
        }
        private void Rectangle_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(color, 5);
            Graphics g = CreateGraphics();
            if (width > 640 || height > 520) MessageBox.Show("Rectangle`s parameters more than workout panel!", "Error!");
            else
            {
                if (width != 0 || height != 0) g.DrawRectangle(pn, 50, 50, width, height);
                else g.DrawRectangle(pn, 50, 50, 100, 100);
            }
        }
    }
}
