
namespace WindowsForms
{
    public partial class LabTask : Form
    {
        public LabTask()
        {
            InitializeComponent();
            this.Shown += Run;
        }
        private void Run(object sender, EventArgs e)
        {
            DialogResult gameResult, exitResult; int counter = 1;
            while (true)
            {
                gameResult = MessageBox.Show($"{new Random().Next(1, 2000)}", "You guessed the number?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (gameResult == DialogResult.Yes)
                {
                    MessageBox.Show($"Queries quantity is {counter}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    counter = 0;
                    exitResult = MessageBox.Show($"Do you want to continue?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (exitResult == DialogResult.No) Application.Exit();
                }
                counter++;
            }
        }
    }
}
