using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class HwMainForm : Form
    {
        public HwMainForm()
        {
            InitializeComponent();
        }

        private void Task1_Click(object sender, EventArgs e)
        {
            HWTask1Form task1 = new HWTask1Form();
            task1.ShowDialog();
        }

        private void Task2_Click(object sender, EventArgs e)
        {
            HWTask2Form task2 = new HWTask2Form();
            task2.ShowDialog();
        }

        private void Task3_Click(object sender, EventArgs e)
        {
            HWTask3Form task3 = new HWTask3Form();
            task3.ShowDialog();
        }
    }
}
