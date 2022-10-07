namespace WindowsForms
{
    partial class HWTask3Form
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
            this.DateTB = new MaterialSkin.Controls.MaterialTextBox();
            this.MonthTB = new MaterialSkin.Controls.MaterialTextBox();
            this.YearTB = new MaterialSkin.Controls.MaterialTextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.OKButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // DateTB
            // 
            this.DateTB.AnimateReadOnly = false;
            this.DateTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateTB.Depth = 0;
            this.DateTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DateTB.Hint = "Date";
            this.DateTB.LeadingIcon = null;
            this.DateTB.Location = new System.Drawing.Point(43, 37);
            this.DateTB.MaxLength = 50;
            this.DateTB.MouseState = MaterialSkin.MouseState.OUT;
            this.DateTB.Multiline = false;
            this.DateTB.Name = "DateTB";
            this.DateTB.Size = new System.Drawing.Size(100, 50);
            this.DateTB.TabIndex = 0;
            this.DateTB.Text = "";
            this.DateTB.TrailingIcon = null;
            // 
            // MonthTB
            // 
            this.MonthTB.AnimateReadOnly = false;
            this.MonthTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MonthTB.Depth = 0;
            this.MonthTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MonthTB.Hint = "Month";
            this.MonthTB.LeadingIcon = null;
            this.MonthTB.Location = new System.Drawing.Point(189, 37);
            this.MonthTB.MaxLength = 50;
            this.MonthTB.MouseState = MaterialSkin.MouseState.OUT;
            this.MonthTB.Multiline = false;
            this.MonthTB.Name = "MonthTB";
            this.MonthTB.Size = new System.Drawing.Size(100, 50);
            this.MonthTB.TabIndex = 1;
            this.MonthTB.Text = "";
            this.MonthTB.TrailingIcon = null;
            // 
            // YearTB
            // 
            this.YearTB.AnimateReadOnly = false;
            this.YearTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YearTB.Depth = 0;
            this.YearTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.YearTB.Hint = "Year";
            this.YearTB.LeadingIcon = null;
            this.YearTB.Location = new System.Drawing.Point(336, 37);
            this.YearTB.MaxLength = 50;
            this.YearTB.MouseState = MaterialSkin.MouseState.OUT;
            this.YearTB.Multiline = false;
            this.YearTB.Name = "YearTB";
            this.YearTB.Size = new System.Drawing.Size(133, 50);
            this.YearTB.TabIndex = 2;
            this.YearTB.Text = "";
            this.YearTB.TrailingIcon = null;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(305, 127);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(164, 68);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(5, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = ".";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(312, 68);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(5, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = ".";
            // 
            // OKButton
            // 
            this.OKButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OKButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OKButton.Depth = 0;
            this.OKButton.HighEmphasis = true;
            this.OKButton.Icon = null;
            this.OKButton.Location = new System.Drawing.Point(127, 163);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OKButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKButton.Name = "OKButton";
            this.OKButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OKButton.Size = new System.Drawing.Size(64, 36);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OKButton.UseAccentColor = false;
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // HWTask3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 327);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.YearTB);
            this.Controls.Add(this.MonthTB);
            this.Controls.Add(this.DateTB);
            this.Name = "HWTask3Form";
            this.Text = "HWTask3Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox DateTB;
        private MaterialSkin.Controls.MaterialTextBox MonthTB;
        private MaterialSkin.Controls.MaterialTextBox YearTB;
        private MonthCalendar monthCalendar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton OKButton;
    }
}