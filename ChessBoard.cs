
namespace WindowsForms
{
    public partial class ChessBoard : Form
    {
        public ChessBoard()
        {
            InitializeComponent();
        }
        private void ChessBoard_Paint(object sender, PaintEventArgs e)
        {
            bool isBlack = false;
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);
            Rectangle rect = new Rectangle();
            Graphics gfx = e.Graphics;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (isBlack)
                    {
                        rect = new Rectangle(i * 20, j * 20, 20, 20);
                        gfx.DrawRectangle(pen, rect);
                        gfx.FillRectangle(brush, rect);
                        isBlack = false;
                    }
                    else isBlack = true;
                }
                isBlack = !isBlack;
            }
        }
    }
}
