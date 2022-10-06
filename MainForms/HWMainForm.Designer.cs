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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Task1
            // 
            this.Task1.Location = new System.Drawing.Point(78, 111);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(119, 43);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "Task 1";
            this.Task1.UseVisualStyleBackColor = true;
            this.Task1.Click += new System.EventHandler(this.Task1_Click);
            // 
            // Task2
            // 
            this.Task2.Location = new System.Drawing.Point(240, 111);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(117, 43);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Task 2";
            this.Task2.UseVisualStyleBackColor = true;
            this.Task2.Click += new System.EventHandler(this.Task2_Click);
            // 
            // Task3
            // 
            this.Task3.Location = new System.Drawing.Point(403, 111);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(118, 43);
            this.Task3.TabIndex = 2;
            this.Task3.Text = "Task 3";
            this.Task3.UseVisualStyleBackColor = true;
            this.Task3.Click += new System.EventHandler(this.Task3_Click);
            // 
            // Task4
            // 
            this.Task4.Location = new System.Drawing.Point(159, 180);
            this.Task4.Name = "Task4";
            this.Task4.Size = new System.Drawing.Size(118, 45);
            this.Task4.TabIndex = 3;
            this.Task4.Text = "Task 4";
            this.Task4.UseVisualStyleBackColor = true;
            this.Task4.Click += new System.EventHandler(this.Task4_Click);
            // 
            // Task5
            // 
            this.Task5.Location = new System.Drawing.Point(323, 180);
            this.Task5.Name = "Task5";
            this.Task5.Size = new System.Drawing.Size(116, 45);
            this.Task5.TabIndex = 4;
            this.Task5.Text = "Task 5";
            this.Task5.UseVisualStyleBackColor = true;
            this.Task5.Click += new System.EventHandler(this.Task5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter task to check";
            // 
            // HWMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 304);
            this.Controls.Add(this.label1);
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
        private Label label1;
    }
}