using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms
{
    public partial class HWTask1 : Form
    {
        public HWTask1()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();
        private void BeginButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"ProgressBarData.txt"))
            {
                string fileValue = System.IO.File.ReadAllText(@"ProgressBarData.txt");
                materialProgressBar.Minimum = 0;
                materialProgressBar.Maximum = 300;
                materialProgressBar.Value = fileValue.Length;
                progressBar.Minimum = 0;
                progressBar.Maximum = 300;
                progressBar.Value = fileValue.Length;
            }
            else MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
