
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
        private void OKLabTask1Button_Click(object sender, EventArgs e)
        {
            Font boldFont = new Font("Segoe UI", 9, FontStyle.Bold);
            Font underlinedFont = new Font("Segoe UI", 9, FontStyle.Underline);
            Font strikeoutFont = new Font("Segoe UI", 9, FontStyle.Strikeout);
            if (BoldCB.Checked) CheckingLabel.Font = boldFont;
            if (UnderlinedCB.Checked) CheckingLabel.Font = underlinedFont;
            if (StrikeOutCB.Checked) CheckingLabel.Font = strikeoutFont;
            int fontSize = Convert.ToInt32(FontCB.Text);
            CheckingLabel.Font = new Font("Segoe UI", fontSize);
        }
        private void ResetLabTask1Button_Click(object sender, EventArgs e)
        {
            CheckingLabel.Font = new Font("Segoe UI", 9);
            BoldCB.Checked = false;
            UnderlinedCB.Checked = false;
            StrikeOutCB.Checked = false;
            FontCB.Text = "";
        }


        private void OKLab2TaskButton_Click(object sender, EventArgs e)
        {
            if (FirstTextRB.Checked) ResultLabel.Text = FirstTextRB.Text;
            else if (SecondTextRB.Checked) ResultLabel.Text = SecondTextRB.Text;
            if (RedColorRB.Checked) ResultLabel.ForeColor = Color.Red;
            else if (GreenColorRB.Checked) ResultLabel.ForeColor = Color.Green;
            else if (BlueColorRB.Checked) ResultLabel.ForeColor = Color.Blue;
            int fontSize = Convert.ToInt32(SizeFontCB.Text);
            ResultLabel.Font = new Font("Segoe UI", fontSize);
        }
        private void ResetLab2TaskButton_Click(object sender, EventArgs e)
        {
            FirstTextRB.Checked = false;
            SecondTextRB.Checked = false;
            RedColorRB.Checked = false;
            GreenColorRB.Checked = false;
            BlueColorRB.Checked = false;
            SizeFontCB.Text = "";
        }
    }
}
