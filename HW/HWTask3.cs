
namespace WindowsForms
{
    public partial class HWTask3 : Form
    {
        public HWTask3()
        {
            InitializeComponent();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (enterTextBox.Text == "")
            {
                resTextBox.Text = dateTimePicker.Value.Date.ToString("dddd");
                enterTextBox.Text = dateTimePicker.Value.ToShortDateString();
            }
            else
            {
                try
                {
                    DateTime day = new DateTime();
                    day = DateTime.Parse(enterTextBox.Text);
                    resTextBox.Text = day.ToString("dddd");
                    dateTimePicker.Value = day;
                }
                catch (Exception) {  enterTextBox.BackColor = Color.LightCoral; }
            }
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            enterTextBox.Clear();
            enterTextBox.BackColor = Color.White;
            dateTimePicker.Value = DateTime.Now;
        }
    }
}
