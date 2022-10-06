namespace WindowsForms
{
    partial class HWTask3
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
            this.enterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.resTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // enterTextBox
            // 
            this.enterTextBox.Location = new System.Drawing.Point(96, 35);
            this.enterTextBox.Name = "enterTextBox";
            this.enterTextBox.Size = new System.Drawing.Size(134, 23);
            this.enterTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter date:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(338, 71);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(110, 35);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(338, 129);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(110, 35);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // resTextBox
            // 
            this.resTextBox.Location = new System.Drawing.Point(96, 202);
            this.resTextBox.Name = "resTextBox";
            this.resTextBox.Size = new System.Drawing.Size(134, 23);
            this.resTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Result:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(27, 78);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(221, 23);
            this.dateTimePicker.TabIndex = 7;
            // 
            // HWTask3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 257);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterTextBox);
            this.Name = "HWTask3";
            this.Text = "HWTask3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox enterTextBox;
        private Label label1;
        private Button OKButton;
        private Button ResetButton;
        private TextBox resTextBox;
        private Label label2;
        private DateTimePicker dateTimePicker;
    }
}