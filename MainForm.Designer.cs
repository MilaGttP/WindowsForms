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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.Task1 = new System.Windows.Forms.TabPage();
            this.Task2 = new System.Windows.Forms.TabPage();
            this.Task3 = new System.Windows.Forms.TabPage();
            this.Task4 = new System.Windows.Forms.TabPage();
            this.Task5 = new System.Windows.Forms.TabPage();
            this.Task6 = new System.Windows.Forms.TabPage();
            this.Task7 = new System.Windows.Forms.TabPage();
            this.Task8 = new System.Windows.Forms.TabPage();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.Task1);
            this.MainTabControl.Controls.Add(this.Task2);
            this.MainTabControl.Controls.Add(this.Task3);
            this.MainTabControl.Controls.Add(this.Task4);
            this.MainTabControl.Controls.Add(this.Task5);
            this.MainTabControl.Controls.Add(this.Task6);
            this.MainTabControl.Controls.Add(this.Task7);
            this.MainTabControl.Controls.Add(this.Task8);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(919, 551);
            this.MainTabControl.TabIndex = 0;
            // 
            // Task1
            // 
            this.Task1.Location = new System.Drawing.Point(4, 24);
            this.Task1.Name = "Task1";
            this.Task1.Padding = new System.Windows.Forms.Padding(3);
            this.Task1.Size = new System.Drawing.Size(911, 523);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "Task 1";
            this.Task1.UseVisualStyleBackColor = true;
            // 
            // Task2
            // 
            this.Task2.Location = new System.Drawing.Point(4, 24);
            this.Task2.Name = "Task2";
            this.Task2.Padding = new System.Windows.Forms.Padding(3);
            this.Task2.Size = new System.Drawing.Size(911, 523);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Task 2";
            this.Task2.UseVisualStyleBackColor = true;
            // 
            // Task3
            // 
            this.Task3.Location = new System.Drawing.Point(4, 24);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(911, 523);
            this.Task3.TabIndex = 2;
            this.Task3.Text = "Task 3";
            this.Task3.UseVisualStyleBackColor = true;
            // 
            // Task4
            // 
            this.Task4.Location = new System.Drawing.Point(4, 24);
            this.Task4.Name = "Task4";
            this.Task4.Size = new System.Drawing.Size(911, 523);
            this.Task4.TabIndex = 3;
            this.Task4.Text = "Task 4";
            this.Task4.UseVisualStyleBackColor = true;
            // 
            // Task5
            // 
            this.Task5.Location = new System.Drawing.Point(4, 24);
            this.Task5.Name = "Task5";
            this.Task5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Task5.Size = new System.Drawing.Size(911, 523);
            this.Task5.TabIndex = 4;
            this.Task5.Text = "Task 5";
            this.Task5.UseVisualStyleBackColor = true;
            // 
            // Task6
            // 
            this.Task6.Location = new System.Drawing.Point(4, 24);
            this.Task6.Name = "Task6";
            this.Task6.Size = new System.Drawing.Size(911, 523);
            this.Task6.TabIndex = 5;
            this.Task6.Text = "Task 6";
            this.Task6.UseVisualStyleBackColor = true;
            // 
            // Task7
            // 
            this.Task7.Location = new System.Drawing.Point(4, 24);
            this.Task7.Name = "Task7";
            this.Task7.Size = new System.Drawing.Size(911, 523);
            this.Task7.TabIndex = 6;
            this.Task7.Text = "Task 7";
            this.Task7.UseVisualStyleBackColor = true;
            // 
            // Task8
            // 
            this.Task8.Location = new System.Drawing.Point(4, 24);
            this.Task8.Name = "Task8";
            this.Task8.Size = new System.Drawing.Size(911, 523);
            this.Task8.TabIndex = 7;
            this.Task8.Text = "Task 8";
            this.Task8.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 575);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTabControl;
        private TabPage Task1;
        private TabPage Task2;
        private TabPage Task3;
        private TabPage Task4;
        private TabPage Task5;
        private TabPage Task6;
        private TabPage Task7;
        private TabPage Task8;
    }
}