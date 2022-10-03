using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsForms
{
    public partial class LabTask1 : Form
    {
        public LabTask1()
        {
            InitializeComponent();
            this.Shown += Solution;
        }

        private void Solution(object sender, EventArgs e)
        {
            string[] myData = { "Ivanova Liudmila", "16 years", "Having soft skills", "Hard skills: C++, C#, SQL" };
            int symbolsQuantity = 0; string toShowInMessageBox;
            for (int i = 0; i < myData.Length; i++)
            {
                symbolsQuantity += myData[i].Length;
                toShowInMessageBox = (myData.Length - 1 == i) ? 
                    $" MessageBox quantity {i + 1} and average symbols quantity: {symbolsQuantity / myData.Length}" : 
                    $" MessageBox number {i + 1}";
                MessageBox.Show(myData[i], toShowInMessageBox, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}
