namespace WindowsForms
{
    partial class GeometryShapes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeometryShapes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ColorTool = new System.Windows.Forms.ToolStripMenuItem();
            this.Ellipse = new System.Windows.Forms.ToolStripMenuItem();
            this.Rectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.WidthTB = new System.Windows.Forms.TextBox();
            this.HeightTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorTool,
            this.Ellipse,
            this.Rectangle});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // ColorTool
            // 
            this.ColorTool.Name = "ColorTool";
            this.ColorTool.Size = new System.Drawing.Size(89, 20);
            this.ColorTool.Text = "Choose color";
            this.ColorTool.Click += new System.EventHandler(this.ColorTool_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("Ellipse.Image")));
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(68, 20);
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(87, 20);
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.HeightTB);
            this.panel.Controls.Add(this.WidthTB);
            this.panel.Location = new System.Drawing.Point(681, 152);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(260, 209);
            this.panel.TabIndex = 1;
            // 
            // WidthTB
            // 
            this.WidthTB.Location = new System.Drawing.Point(25, 43);
            this.WidthTB.Name = "WidthTB";
            this.WidthTB.Size = new System.Drawing.Size(213, 23);
            this.WidthTB.TabIndex = 0;
            this.WidthTB.TextChanged += new System.EventHandler(this.WidthTB_TextChanged);
            // 
            // HeightTB
            // 
            this.HeightTB.Location = new System.Drawing.Point(25, 137);
            this.HeightTB.Name = "HeightTB";
            this.HeightTB.Size = new System.Drawing.Size(213, 23);
            this.HeightTB.TabIndex = 1;
            this.HeightTB.TextChanged += new System.EventHandler(this.HeightTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter height:";
            // 
            // GeometryShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 561);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GeometryShapes";
            this.Text = "GeometryShapes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ColorTool;
        private ToolStripMenuItem Ellipse;
        private ToolStripMenuItem Rectangle;
        private Panel panel;
        private Label label2;
        private Label label1;
        private TextBox HeightTB;
        private TextBox WidthTB;
    }
}