namespace WindowsForms
{
    partial class HWTask1
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
            this.materialProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ExitButton = new MaterialSkin.Controls.MaterialButton();
            this.BeginButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialProgressBar
            // 
            this.materialProgressBar.Depth = 0;
            this.materialProgressBar.Location = new System.Drawing.Point(56, 83);
            this.materialProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar.Name = "materialProgressBar";
            this.materialProgressBar.Size = new System.Drawing.Size(325, 5);
            this.materialProgressBar.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(56, 45);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Progress:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(56, 94);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(325, 23);
            this.progressBar.TabIndex = 3;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ExitButton.Depth = 0;
            this.ExitButton.HighEmphasis = true;
            this.ExitButton.Icon = null;
            this.ExitButton.Location = new System.Drawing.Point(151, 143);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ExitButton.Size = new System.Drawing.Size(64, 36);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExitButton.UseAccentColor = false;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BeginButton
            // 
            this.BeginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BeginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BeginButton.Depth = 0;
            this.BeginButton.HighEmphasis = true;
            this.BeginButton.Icon = null;
            this.BeginButton.Location = new System.Drawing.Point(56, 143);
            this.BeginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BeginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BeginButton.Size = new System.Drawing.Size(64, 36);
            this.BeginButton.TabIndex = 5;
            this.BeginButton.Text = "Begin";
            this.BeginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BeginButton.UseAccentColor = false;
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // HWTask1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 214);
            this.Controls.Add(this.BeginButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialProgressBar);
            this.Name = "HWTask1";
            this.Text = "HWTask1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private ProgressBar progressBar;
        private MaterialSkin.Controls.MaterialButton ExitButton;
        private MaterialSkin.Controls.MaterialButton BeginButton;
    }
}