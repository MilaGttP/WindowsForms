namespace WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Task1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.WorkersQuantityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ResultWorkersLB = new System.Windows.Forms.ListBox();
            this.WorkersLB = new System.Windows.Forms.ListBox();
            this.Task2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultStudentsLB = new System.Windows.Forms.ListBox();
            this.StudentsLB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Task1.SuspendLayout();
            this.Task2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Task1);
            this.tabControl.Controls.Add(this.Task2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(812, 520);
            this.tabControl.TabIndex = 0;
            // 
            // Task1
            // 
            this.Task1.Controls.Add(this.textBox2);
            this.Task1.Controls.Add(this.WorkersQuantityLabel);
            this.Task1.Controls.Add(this.label1);
            this.Task1.Controls.Add(this.textBox1);
            this.Task1.Controls.Add(this.ResultWorkersLB);
            this.Task1.Controls.Add(this.WorkersLB);
            this.Task1.Location = new System.Drawing.Point(4, 24);
            this.Task1.Name = "Task1";
            this.Task1.Padding = new System.Windows.Forms.Padding(3);
            this.Task1.Size = new System.Drawing.Size(804, 492);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "Task 1";
            this.Task1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(331, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            // 
            // WorkersQuantityLabel
            // 
            this.WorkersQuantityLabel.AutoSize = true;
            this.WorkersQuantityLabel.Location = new System.Drawing.Point(37, 96);
            this.WorkersQuantityLabel.Name = "WorkersQuantityLabel";
            this.WorkersQuantityLabel.Size = new System.Drawing.Size(100, 15);
            this.WorkersQuantityLabel.TabIndex = 4;
            this.WorkersQuantityLabel.Text = "Workers quantity:";
            this.WorkersQuantityLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a city:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 23);
            this.textBox1.TabIndex = 2;
            // 
            // ResultWorkersLB
            // 
            this.ResultWorkersLB.FormattingEnabled = true;
            this.ResultWorkersLB.ItemHeight = 15;
            this.ResultWorkersLB.Location = new System.Drawing.Point(20, 156);
            this.ResultWorkersLB.Name = "ResultWorkersLB";
            this.ResultWorkersLB.Size = new System.Drawing.Size(364, 319);
            this.ResultWorkersLB.TabIndex = 1;
            this.ResultWorkersLB.Visible = false;
            // 
            // WorkersLB
            // 
            this.WorkersLB.FormattingEnabled = true;
            this.WorkersLB.ItemHeight = 15;
            this.WorkersLB.Location = new System.Drawing.Point(413, 21);
            this.WorkersLB.Name = "WorkersLB";
            this.WorkersLB.Size = new System.Drawing.Size(374, 454);
            this.WorkersLB.TabIndex = 0;
            // 
            // Task2
            // 
            this.Task2.Controls.Add(this.label3);
            this.Task2.Controls.Add(this.label2);
            this.Task2.Controls.Add(this.ResultStudentsLB);
            this.Task2.Controls.Add(this.StudentsLB);
            this.Task2.Location = new System.Drawing.Point(4, 24);
            this.Task2.Name = "Task2";
            this.Task2.Padding = new System.Windows.Forms.Padding(3);
            this.Task2.Size = new System.Drawing.Size(804, 492);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Task 2";
            this.Task2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "General data:";
            // 
            // ResultStudentsLB
            // 
            this.ResultStudentsLB.FormattingEnabled = true;
            this.ResultStudentsLB.ItemHeight = 15;
            this.ResultStudentsLB.Location = new System.Drawing.Point(419, 63);
            this.ResultStudentsLB.Name = "ResultStudentsLB";
            this.ResultStudentsLB.Size = new System.Drawing.Size(356, 409);
            this.ResultStudentsLB.TabIndex = 1;
            // 
            // StudentsLB
            // 
            this.StudentsLB.FormattingEnabled = true;
            this.StudentsLB.ItemHeight = 15;
            this.StudentsLB.Location = new System.Drawing.Point(28, 63);
            this.StudentsLB.Name = "StudentsLB";
            this.StudentsLB.Size = new System.Drawing.Size(345, 409);
            this.StudentsLB.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 544);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.Task1.ResumeLayout(false);
            this.Task1.PerformLayout();
            this.Task2.ResumeLayout(false);
            this.Task2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage Task1;
        private TabPage Task2;
        private ListBox ResultWorkersLB;
        private ListBox WorkersLB;
        private Label label1;
        private TextBox textBox1;
        private ListBox ResultStudentsLB;
        private ListBox StudentsLB;
        private Label label2;
        private TextBox textBox2;
        private Label WorkersQuantityLabel;
        private Label label3;
    }
}