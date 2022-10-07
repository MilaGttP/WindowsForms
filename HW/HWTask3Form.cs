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
    public partial class HWTask3Form : Form
    {
        public HWTask3Form()
        {
            InitializeComponent();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            int day = int.Parse(DateTB.Text);
            int month = int.Parse(MonthTB.Text);
            int year = int.Parse(YearTB.Text);
            DateTime newDT = new DateTime(day, month, year);
            monthCalendar.SetDate(newDT);
        }
    }
}
