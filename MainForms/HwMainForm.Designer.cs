namespace WindowsForms
{
    partial class HwMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Task1 = new System.Windows.Forms.Button();
            this.Task2 = new System.Windows.Forms.Button();
            this.Task3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose task to check";
            // 
            // Task1
            // 
            this.Task1.Location = new System.Drawing.Point(139, 87);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(119, 33);
            this.Task1.TabIndex = 1;
            this.Task1.Text = "Task 1";
            this.Task1.UseVisualStyleBackColor = true;
            this.Task1.Click += new System.EventHandler(this.Task1_Click);
            // 
            // Task2
            // 
            this.Task2.Location = new System.Drawing.Point(139, 138);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(119, 31);
            this.Task2.TabIndex = 2;
            this.Task2.Text = "Task 2";
            this.Task2.UseVisualStyleBackColor = true;
            this.Task2.Click += new System.EventHandler(this.Task2_Click);
            // 
            // Task3
            // 
            this.Task3.Location = new System.Drawing.Point(139, 188);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(119, 30);
            this.Task3.TabIndex = 3;
            this.Task3.Text = "Task 3";
            this.Task3.UseVisualStyleBackColor = true;
            this.Task3.Click += new System.EventHandler(this.Task3_Click);
            // 
            // HwMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 296);
            this.Controls.Add(this.Task3);
            this.Controls.Add(this.Task2);
            this.Controls.Add(this.Task1);
            this.Controls.Add(this.label1);
            this.Name = "HwMainForm";
            this.Text = "HwMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Task1;
        private Button Task2;
        private Button Task3;
    }
}