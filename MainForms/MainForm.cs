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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Lab_Click(object sender, EventArgs e)
        {
            LabForm labForm = new LabForm();
            labForm.ShowDialog();
        }

        private void HW_Click(object sender, EventArgs e)
        {
            HwMainForm hwMainForm = new HwMainForm();
            hwMainForm.ShowDialog();
        }
    }
}
