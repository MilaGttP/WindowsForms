namespace WindowsForms
{
    partial class ComputerAuxForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PriceTB = new MaterialSkin.Controls.MaterialTextBox();
            this.DescriptionTB = new MaterialSkin.Controls.MaterialTextBox();
            this.NameTB = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(459, 167);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(261, 53);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(459, 84);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(261, 57);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // PriceTB
            // 
            this.PriceTB.AnimateReadOnly = false;
            this.PriceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTB.Depth = 0;
            this.PriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PriceTB.Hint = "Price";
            this.PriceTB.LeadingIcon = null;
            this.PriceTB.Location = new System.Drawing.Point(58, 196);
            this.PriceTB.MaxLength = 50;
            this.PriceTB.MouseState = MaterialSkin.MouseState.OUT;
            this.PriceTB.Multiline = false;
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(297, 50);
            this.PriceTB.TabIndex = 7;
            this.PriceTB.Text = "";
            this.PriceTB.TrailingIcon = null;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.AnimateReadOnly = false;
            this.DescriptionTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTB.Depth = 0;
            this.DescriptionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DescriptionTB.Hint = "Description";
            this.DescriptionTB.LeadingIcon = null;
            this.DescriptionTB.Location = new System.Drawing.Point(58, 140);
            this.DescriptionTB.MaxLength = 50;
            this.DescriptionTB.MouseState = MaterialSkin.MouseState.OUT;
            this.DescriptionTB.Multiline = false;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(297, 50);
            this.DescriptionTB.TabIndex = 6;
            this.DescriptionTB.Text = "";
            this.DescriptionTB.TrailingIcon = null;
            // 
            // NameTB
            // 
            this.NameTB.AnimateReadOnly = false;
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTB.Depth = 0;
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NameTB.Hint = "Name";
            this.NameTB.LeadingIcon = null;
            this.NameTB.Location = new System.Drawing.Point(58, 84);
            this.NameTB.MaxLength = 50;
            this.NameTB.MouseState = MaterialSkin.MouseState.OUT;
            this.NameTB.Multiline = false;
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(297, 50);
            this.NameTB.TabIndex = 5;
            this.NameTB.Text = "";
            this.NameTB.TrailingIcon = null;
            // 
            // ComputerAuxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.NameTB);
            this.Name = "ComputerAuxForm";
            this.Text = "ComputerAuxForm";
            this.Load += new System.EventHandler(this.ComputerAuxForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button CancelButton;
        private Button AddButton;
        private MaterialSkin.Controls.MaterialTextBox PriceTB;
        private MaterialSkin.Controls.MaterialTextBox DescriptionTB;
        private MaterialSkin.Controls.MaterialTextBox NameTB;
    }
}