
namespace AffineTransforms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Point = new System.Windows.Forms.ToolStripButton();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.Square = new System.Windows.Forms.ToolStripButton();
            this.Clear = new System.Windows.Forms.ToolStripButton();
            this.Transfer = new System.Windows.Forms.ToolStripButton();
            this.Rotate = new System.Windows.Forms.ToolStripButton();
            this.RotatePoint = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Point,
            this.Line,
            this.Square,
            this.Clear,
            this.Transfer,
            this.Rotate,
            this.RotatePoint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Point
            // 
            this.Point.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Point.Image = ((System.Drawing.Image)(resources.GetObject("Point.Image")));
            this.Point.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(46, 28);
            this.Point.Text = "Point";
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(40, 28);
            this.Line.Text = "Line";
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Square
            // 
            this.Square.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Square.Image = ((System.Drawing.Image)(resources.GetObject("Square.Image")));
            this.Square.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(59, 28);
            this.Square.Text = "Square";
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Clear
            // 
            this.Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Clear.Image = ((System.Drawing.Image)(resources.GetObject("Clear.Image")));
            this.Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(47, 28);
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Transfer
            // 
            this.Transfer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Transfer.Image = ((System.Drawing.Image)(resources.GetObject("Transfer.Image")));
            this.Transfer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(50, 28);
            this.Transfer.Text = "Move";
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // Rotate
            // 
            this.Rotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Rotate.Image = ((System.Drawing.Image)(resources.GetObject("Rotate.Image")));
            this.Rotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(57, 28);
            this.Rotate.Text = "Rotate";
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // RotatePoint
            // 
            this.RotatePoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RotatePoint.Image = ((System.Drawing.Image)(resources.GetObject("RotatePoint.Image")));
            this.RotatePoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RotatePoint.Name = "RotatePoint";
            this.RotatePoint.Size = new System.Drawing.Size(106, 28);
            this.RotatePoint.Text = "RotateAround";
            this.RotatePoint.Click += new System.EventHandler(this.RotatePoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Point;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.ToolStripButton Square;
        private System.Windows.Forms.ToolStripButton Clear;
        private System.Windows.Forms.ToolStripButton Transfer;
        private System.Windows.Forms.ToolStripButton Rotate;
        private System.Windows.Forms.ToolStripButton RotatePoint;
    }
}

