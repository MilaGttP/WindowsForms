﻿namespace WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.HWButoon = new System.Windows.Forms.Button();
            this.LabButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you want to check?";
            // 
            // HWButoon
            // 
            this.HWButoon.Location = new System.Drawing.Point(65, 98);
            this.HWButoon.Name = "HWButoon";
            this.HWButoon.Size = new System.Drawing.Size(147, 43);
            this.HWButoon.TabIndex = 1;
            this.HWButoon.Text = "HomeWork";
            this.HWButoon.UseVisualStyleBackColor = true;
            this.HWButoon.Click += new System.EventHandler(this.HWButton_Click);
            // 
            // LabButton
            // 
            this.LabButton.Location = new System.Drawing.Point(316, 98);
            this.LabButton.Name = "LabButton";
            this.LabButton.Size = new System.Drawing.Size(135, 43);
            this.LabButton.TabIndex = 2;
            this.LabButton.Text = "LaboratoryWork";
            this.LabButton.UseVisualStyleBackColor = true;
            this.LabButton.Click += new System.EventHandler(this.LabButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 206);
            this.Controls.Add(this.LabButton);
            this.Controls.Add(this.HWButoon);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button HWButoon;
        private Button LabButton;
    }
}