
namespace WindowsForms
{
    public partial class HWTask1 : Form
    {
        int X { get; set; }
        int Y { get; set; }
        int Static { get; set; } = 1;
        public HWTask1()
        {
            InitializeComponent();
            MouseDown += MouseDownMove;
            MouseUp += MouseUpMove;
        }
        private void MouseUpMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = new Label();
                label.BorderStyle = BorderStyle.Fixed3D;
                if (e.X > X && e.Y > Y) label.Location = new Point(X, Y);
                else if (e.X > X && e.Y < Y)label.Location = new Point(X, e.Y);
                else if (e.X < X && e.Y < Y) label.Location = new Point(e.X, e.Y);
                else label.Location = new Point(e.X, Y);
                if (Math.Abs(e.X - X) <= 10 || Math.Abs(e.Y - Y) <= 10)
                    MessageBox.Show("Erorr: static less than 10x10", "Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    label.Size = new Size(Math.Abs(e.X - X), Math.Abs(e.Y - Y));
                    label.Text = $"{Static}";
                    label.ForeColor = Color.White;
                    label.BackColor = Color.CadetBlue;
                    Controls.Add(label);
                    Text = $"«Static» #{label.Text} created!";
                    label.MouseClick += LabelMouseClick;
                    label.MouseDoubleClick += LabelMouseDoubleClick;
                    Static++;
                }
            }
            else MessageBox.Show("For creating a static, you need to click LMB", "Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MouseDownMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                X = e.X;
                Y = e.Y;
            }
        }
        private void LabelMouseDoubleClick(object sender, MouseEventArgs e)
        {
            int number = Static;
            if (e.Button == MouseButtons.Left)
            {
                foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X 
                        && MousePosition.X < location.X + item.Width 
                        && MousePosition.Y > location.Y 
                        && MousePosition.Y < location.Y + item.Height)
                        if (number > Convert.ToInt32(item.Text)) number = Convert.ToInt32(item.Text);
                }
                foreach (Label item in Controls)
                {
                    try
                    {
                        if (number == Convert.ToInt32(item.Text))
                        {
                            Text = $"«Static» #{item.Text} deleted!";
                            Controls.Remove(item);
                            item.MouseClick -= LabelMouseClick;
                            item.MouseDoubleClick -= LabelMouseDoubleClick;
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
        private void LabelMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X 
                        && MousePosition.X < location.X + item.Width 
                        && MousePosition.Y > location.Y 
                        && MousePosition.Y < location.Y + item.Height)
                        Text = $"«Static» #{item.Text}, Square {item.Width * item.Height}, " +
                            $"Х = {item.Location.X} Y = {item.Location.Y}";
                }
            }
        }
    }
}
