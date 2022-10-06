namespace WindowsForms
{
    partial class HWTask4
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearRadioButton = new System.Windows.Forms.RadioButton();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.minRadioButton = new System.Windows.Forms.RadioButton();
            this.secRadioButton = new System.Windows.Forms.RadioButton();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(79, 33);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(171, 23);
            this.inputTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input:";
            // 
            // yearRadioButton
            // 
            this.yearRadioButton.AutoSize = true;
            this.yearRadioButton.Location = new System.Drawing.Point(35, 78);
            this.yearRadioButton.Name = "yearRadioButton";
            this.yearRadioButton.Size = new System.Drawing.Size(47, 19);
            this.yearRadioButton.TabIndex = 2;
            this.yearRadioButton.TabStop = true;
            this.yearRadioButton.Text = "Year";
            this.yearRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Location = new System.Drawing.Point(35, 103);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(61, 19);
            this.monthRadioButton.TabIndex = 3;
            this.monthRadioButton.TabStop = true;
            this.monthRadioButton.Text = "Month";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Location = new System.Drawing.Point(35, 128);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(45, 19);
            this.dayRadioButton.TabIndex = 4;
            this.dayRadioButton.TabStop = true;
            this.dayRadioButton.Text = "Day";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            // 
            // minRadioButton
            // 
            this.minRadioButton.AutoSize = true;
            this.minRadioButton.Location = new System.Drawing.Point(35, 153);
            this.minRadioButton.Name = "minRadioButton";
            this.minRadioButton.Size = new System.Drawing.Size(63, 19);
            this.minRadioButton.TabIndex = 5;
            this.minRadioButton.TabStop = true;
            this.minRadioButton.Text = "Minute";
            this.minRadioButton.UseVisualStyleBackColor = true;
            // 
            // secRadioButton
            // 
            this.secRadioButton.AutoSize = true;
            this.secRadioButton.Location = new System.Drawing.Point(35, 178);
            this.secRadioButton.Name = "secRadioButton";
            this.secRadioButton.Size = new System.Drawing.Size(64, 19);
            this.secRadioButton.TabIndex = 6;
            this.secRadioButton.TabStop = true;
            this.secRadioButton.Text = "Second";
            this.secRadioButton.UseVisualStyleBackColor = true;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(89, 220);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(169, 23);
            this.outputTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(321, 78);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(142, 46);
            this.OKButton.TabIndex = 9;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(321, 142);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(142, 44);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HWTask4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 305);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.secRadioButton);
            this.Controls.Add(this.minRadioButton);
            this.Controls.Add(this.dayRadioButton);
            this.Controls.Add(this.monthRadioButton);
            this.Controls.Add(this.yearRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Name = "HWTask4";
            this.Text = "HWTask4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputTextBox;
        private Label label1;
        private RadioButton yearRadioButton;
        private RadioButton monthRadioButton;
        private RadioButton dayRadioButton;
        private RadioButton minRadioButton;
        private RadioButton secRadioButton;
        private TextBox outputTextBox;
        private Label label2;
        private Button OKButton;
        private Button ResetButton;
    }
}