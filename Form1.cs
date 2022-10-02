
namespace WindowsForms
{
    public partial class LabForm : Form
    {
        public LabForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateLabel.Text = String.Format("You entered: {0}", dateTimePicker.Value.ToString());
        }

        private void chooseDateButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}