namespace WindowsForms
{
    partial class LabMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Task1
            // 
            this.Task1.Location = new System.Drawing.Point(137, 99);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(100, 35);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "Task 1";
            this.Task1.UseVisualStyleBackColor = true;
            this.Task1.Click += new System.EventHandler(this.Task1_Click);
            // 
            // Task2
            // 
            this.Task2.Location = new System.Drawing.Point(137, 154);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(100, 32);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Task 2";
            this.Task2.UseVisualStyleBackColor = true;
            this.Task2.Click += new System.EventHandler(this.Task2_Click);
            // 
            // Task3
            // 
            this.Task3.Location = new System.Drawing.Point(137, 207);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(100, 30);
            this.Task3.TabIndex = 2;
            this.Task3.Text = "Task 3";
            this.Task3.UseVisualStyleBackColor = true;
            this.Task3.Click += new System.EventHandler(this.Task3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose task to check";
            // 
            // LabMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Task3);
            this.Controls.Add(this.Task2);
            this.Controls.Add(this.Task1);
            this.Name = "LabMainForm";
            this.Text = "LabMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Task1;
        private Button Task2;
        private Button Task3;
        private Label label1;
    }
}