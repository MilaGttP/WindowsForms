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
        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex == 0)
            {
                RunExplorer();
            }
            else if (MainTabControl.SelectedIndex == 1)
            {

            }
            else if (MainTabControl.SelectedIndex == 2)
            {

            }
            else if (MainTabControl.SelectedIndex == 3)
            {

            }
        }
    }
}
