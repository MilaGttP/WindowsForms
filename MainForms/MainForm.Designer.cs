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
            this.label1 = new System.Windows.Forms.Label();
            this.HW = new System.Windows.Forms.Button();
            this.Lab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "What want you to check?";
            // 
            // HW
            // 
            this.HW.Location = new System.Drawing.Point(56, 98);
            this.HW.Name = "HW";
            this.HW.Size = new System.Drawing.Size(144, 45);
            this.HW.TabIndex = 1;
            this.HW.Text = "HomeWork";
            this.HW.UseVisualStyleBackColor = true;
            this.HW.Click += new System.EventHandler(this.HW_Click);
            // 
            // Lab
            // 
            this.Lab.Location = new System.Drawing.Point(349, 98);
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(151, 45);
            this.Lab.TabIndex = 2;
            this.Lab.Text = "LaboratoryWork";
            this.Lab.UseVisualStyleBackColor = true;
            this.Lab.Click += new System.EventHandler(this.Lab_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 212);
            this.Controls.Add(this.Lab);
            this.Controls.Add(this.HW);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button HW;
        private Button Lab;
    }
}