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
            this.Task1Button = new System.Windows.Forms.Button();
            this.Task2Button = new System.Windows.Forms.Button();
            this.Task3Button = new System.Windows.Forms.Button();
            this.Task4Button = new System.Windows.Forms.Button();
            this.Task5Button = new System.Windows.Forms.Button();
            this.Task6Button = new System.Windows.Forms.Button();
            this.Task7Button = new System.Windows.Forms.Button();
            this.Task8Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task1Button
            // 
            this.Task1Button.Location = new System.Drawing.Point(102, 92);
            this.Task1Button.Name = "Task1Button";
            this.Task1Button.Size = new System.Drawing.Size(156, 40);
            this.Task1Button.TabIndex = 0;
            this.Task1Button.Text = "Task 1";
            this.Task1Button.UseVisualStyleBackColor = true;
            this.Task1Button.Click += new System.EventHandler(this.Task1Button_Click);
            // 
            // Task2Button
            // 
            this.Task2Button.Location = new System.Drawing.Point(294, 92);
            this.Task2Button.Name = "Task2Button";
            this.Task2Button.Size = new System.Drawing.Size(156, 40);
            this.Task2Button.TabIndex = 1;
            this.Task2Button.Text = "Task 2";
            this.Task2Button.UseVisualStyleBackColor = true;
            this.Task2Button.Click += new System.EventHandler(this.Task2Button_Click);
            // 
            // Task3Button
            // 
            this.Task3Button.Location = new System.Drawing.Point(495, 92);
            this.Task3Button.Name = "Task3Button";
            this.Task3Button.Size = new System.Drawing.Size(156, 40);
            this.Task3Button.TabIndex = 2;
            this.Task3Button.Text = "Task 3";
            this.Task3Button.UseVisualStyleBackColor = true;
            this.Task3Button.Click += new System.EventHandler(this.Task3Button_Click);
            // 
            // Task4Button
            // 
            this.Task4Button.Location = new System.Drawing.Point(102, 153);
            this.Task4Button.Name = "Task4Button";
            this.Task4Button.Size = new System.Drawing.Size(156, 40);
            this.Task4Button.TabIndex = 3;
            this.Task4Button.Text = "Task 4";
            this.Task4Button.UseVisualStyleBackColor = true;
            this.Task4Button.Click += new System.EventHandler(this.Task4Button_Click);
            // 
            // Task5Button
            // 
            this.Task5Button.Location = new System.Drawing.Point(294, 153);
            this.Task5Button.Name = "Task5Button";
            this.Task5Button.Size = new System.Drawing.Size(156, 40);
            this.Task5Button.TabIndex = 4;
            this.Task5Button.Text = "Task 5";
            this.Task5Button.UseVisualStyleBackColor = true;
            this.Task5Button.Click += new System.EventHandler(this.Task5Button_Click);
            // 
            // Task6Button
            // 
            this.Task6Button.Location = new System.Drawing.Point(495, 153);
            this.Task6Button.Name = "Task6Button";
            this.Task6Button.Size = new System.Drawing.Size(156, 40);
            this.Task6Button.TabIndex = 5;
            this.Task6Button.Text = "Task 6";
            this.Task6Button.UseVisualStyleBackColor = true;
            this.Task6Button.Click += new System.EventHandler(this.Task6Button_Click);
            // 
            // Task7Button
            // 
            this.Task7Button.Location = new System.Drawing.Point(185, 222);
            this.Task7Button.Name = "Task7Button";
            this.Task7Button.Size = new System.Drawing.Size(156, 40);
            this.Task7Button.TabIndex = 6;
            this.Task7Button.Text = "Task 7";
            this.Task7Button.UseVisualStyleBackColor = true;
            this.Task7Button.Click += new System.EventHandler(this.Task7Button_Click);
            // 
            // Task8Button
            // 
            this.Task8Button.Location = new System.Drawing.Point(393, 222);
            this.Task8Button.Name = "Task8Button";
            this.Task8Button.Size = new System.Drawing.Size(156, 40);
            this.Task8Button.TabIndex = 7;
            this.Task8Button.Text = "Task 8";
            this.Task8Button.UseVisualStyleBackColor = true;
            this.Task8Button.Click += new System.EventHandler(this.Task8Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 375);
            this.Controls.Add(this.Task8Button);
            this.Controls.Add(this.Task7Button);
            this.Controls.Add(this.Task6Button);
            this.Controls.Add(this.Task5Button);
            this.Controls.Add(this.Task4Button);
            this.Controls.Add(this.Task3Button);
            this.Controls.Add(this.Task2Button);
            this.Controls.Add(this.Task1Button);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Task1Button;
        private Button Task2Button;
        private Button Task3Button;
        private Button Task4Button;
        private Button Task5Button;
        private Button Task6Button;
        private Button Task7Button;
        private Button Task8Button;
    }
}