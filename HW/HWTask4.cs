
namespace WindowsForms
{
    public partial class HWTask4 : Form
    {
        public HWTask4()
        {
            InitializeComponent();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dayTime = new DateTime();
                dayTime = DateTime.Parse(inputTextBox.Text);
                DateTime dayNow = DateTime.Now;
                TimeSpan tempDay = dayTime - dayNow;
                if (dayTime > dayNow)
                {
                    if (yearRadioButton.Checked) outputTextBox.Text = (tempDay.TotalDays / 365).ToString();
                    else if (monthRadioButton.Checked) outputTextBox.Text = (tempDay.TotalDays / 30).ToString();
                    else if (dayRadioButton.Checked) outputTextBox.Text = ((int)tempDay.TotalDays).ToString();
                    else if (minRadioButton.Checked) outputTextBox.Text = ((int)tempDay.TotalMinutes).ToString();
                    else if (secRadioButton.Checked) outputTextBox.Text = ((int)tempDay.TotalSeconds).ToString();
                }
                else outputTextBox.Text = "This date have already passed!";
            }
            catch (Exception) { inputTextBox.BackColor = Color.LightCoral; }
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            outputTextBox.Clear();
            yearRadioButton.Checked = true;
        }
    }
}
