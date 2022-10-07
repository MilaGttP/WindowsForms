
namespace WindowsForms
{
    public partial class LabTask2 : Form
    {
        public LabTask2()
        {
            InitializeComponent();
            this.Shown += Run;
        }
        private void Run (object sender, EventArgs e)
        {
            DialogResult result; int counter = 1;
            while (true)
            {
                result = MessageBox.Show($"{new Random().Next(1, 2000)}", "You guessed the number?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show($"Queries quantity is {counter}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    counter = 0;
                    result = MessageBox.Show($"Do you want to continue?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) Application.Exit();
                }
                counter++;
            }
        }
    }
}
