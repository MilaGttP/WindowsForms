namespace WindowsForms
{
    partial class HWMainForm
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
            this.Task1 = new System.Windows.Forms.Button();
            this.Task2 = new System.Windows.Forms.Button();
            this.Task3 = new System.Windows.Forms.Button();
            this.Task4 = new System.Windows.Forms.Button();
            this.Task5 = new System.Windows.Forms.Button();
            this.Task6 = new System.Windows.Forms.Button();
            this.Task7 = new System.Windows.Forms.Button();
            this.Task8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Task1
            // 
            this.Task1.Location = new System.Drawing.Point(125, 111);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(87, 30);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "Task 1";
            this.Task1.UseVisualStyleBackColor = true;
            this.Task1.Click += new System.EventHandler(this.Task1_Click);
            // 
            // Task2
            // 
            this.Task2.Location = new System.Drawing.Point(262, 111);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(85, 30);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Task 2";
            this.Task2.UseVisualStyleBackColor = true;
            // 
            // Task3
            // 
            this.Task3.Location = new System.Drawing.Point(401, 111);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(86, 30);
            this.Task3.TabIndex = 2;
            this.Task3.Text = "Task 3";
            this.Task3.UseVisualStyleBackColor = true;
            // 
            // Task4
            // 
            this.Task4.Location = new System.Drawing.Point(125, 167);
            this.Task4.Name = "Task4";
            this.Task4.Size = new System.Drawing.Size(87, 30);
            this.Task4.TabIndex = 3;
            this.Task4.Text = "Task 4";
            this.Task4.UseVisualStyleBackColor = true;
            // 
            // Task5
            // 
            this.Task5.Location = new System.Drawing.Point(262, 167);
            this.Task5.Name = "Task5";
            this.Task5.Size = new System.Drawing.Size(85, 30);
            this.Task5.TabIndex = 4;
            this.Task5.Text = "Task 5";
            this.Task5.UseVisualStyleBackColor = true;
            // 
            // Task6
            // 
            this.Task6.Location = new System.Drawing.Point(401, 167);
            this.Task6.Name = "Task6";
            this.Task6.Size = new System.Drawing.Size(86, 30);
            this.Task6.TabIndex = 5;
            this.Task6.Text = "Task 6";
            this.Task6.UseVisualStyleBackColor = true;
            // 
            // Task7
            // 
            this.Task7.Location = new System.Drawing.Point(187, 224);
            this.Task7.Name = "Task7";
            this.Task7.Size = new System.Drawing.Size(85, 31);
            this.Task7.TabIndex = 6;
            this.Task7.Text = "Task 7";
            this.Task7.UseVisualStyleBackColor = true;
            // 
            // Task8
            // 
            this.Task8.Location = new System.Drawing.Point(333, 224);
            this.Task8.Name = "Task8";
            this.Task8.Size = new System.Drawing.Size(91, 31);
            this.Task8.TabIndex = 7;
            this.Task8.Text = "Task 8";
            this.Task8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter task to check";
            // 
            // HWMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Task8);
            this.Controls.Add(this.Task7);
            this.Controls.Add(this.Task6);
            this.Controls.Add(this.Task5);
            this.Controls.Add(this.Task4);
            this.Controls.Add(this.Task3);
            this.Controls.Add(this.Task2);
            this.Controls.Add(this.Task1);
            this.Name = "HWMainForm";
            this.Text = "HWMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Task1;
        private Button Task2;
        private Button Task3;
        private Button Task4;
        private Button Task5;
        private Button Task6;
        private Button Task7;
        private Button Task8;
        private Label label1;
    }
}