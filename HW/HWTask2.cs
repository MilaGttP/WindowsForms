
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
    public partial class HWTask2 : Form
    {
        Label label;
        public HWTask2()
        {
            InitializeComponent();
            label = new Label();
            this.Load += Loading;
            this.MouseMove += MouseMovement;
        }
        private void Loading(object sender, EventArgs e)
        {
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Size = new Size(100, 40);
            label.Text = "I`m a static :)";
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.AutoSize = false;
            label.ForeColor = Color.White;
            label.BackColor = Color.CadetBlue;
            Controls.Add(label);
            LabelCenter(label);
        }
        void LabelCenter(Label lable)
        {
            label.Left = (ClientSize.Width - label.Size.Width) / 2;
            label.Top = (ClientSize.Height - label.Size.Height) / 2;
        }
        private void MouseMovement(object sender, MouseEventArgs e)
        {
            if ((e.X > label.Location.X - 20 && e.X < label.Location.X + label.Width + 20) && (e.Y > label.Location.Y - 20 && e.Y < label.Location.Y + label.Height + 20))
            {
                if (e.X > label.Location.X - 20 
                    && e.X < label.Location.X)
                    label.Left += 10;

                else if (e.X < label.Location.X + label.Width + 20 
                    && e.X > label.Location.X + label.Width)
                    label.Left -= 10;

                else if (e.Y > label.Location.Y - 20 
                    && e.Y < label.Location.Y)
                    label.Top += 10;

                else if (e.Y < label.Location.Y + label.Height + 20 
                    && e.Y > label.Location.Y + label.Height)
                    label.Top -= 10;

                if ((label.Location.X < 0 || label.Location.X > ClientSize.Width - label.Width) 
                    || (label.Location.Y < 0 || label.Location.Y > ClientSize.Height - label.Height))
                    LabelCenter(label);
            }
        }
    }
}