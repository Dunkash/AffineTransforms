
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
            this.IntersectionBtn = new System.Windows.Forms.ToolStripButton();
            this.PolygonBtm = new System.Windows.Forms.ToolStripButton();
            this.rt90_btn = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.alpha = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beta = new System.Windows.Forms.NumericUpDown();
            this.scale_btn = new System.Windows.Forms.Button();
            this.p_scale_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(83, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2419, 1271);
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
            this.RotatePoint,
            this.IntersectionBtn,
            this.PolygonBtm,
            this.rt90_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(2129, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Point
            // 
            this.Point.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Point.Image = ((System.Drawing.Image)(resources.GetObject("Point.Image")));
            this.Point.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(39, 22);
            this.Point.Text = "Point";
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(33, 22);
            this.Line.Text = "Line";
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Square
            // 
            this.Square.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Square.Image = ((System.Drawing.Image)(resources.GetObject("Square.Image")));
            this.Square.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(47, 22);
            this.Square.Text = "Square";
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Clear
            // 
            this.Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Clear.Image = ((System.Drawing.Image)(resources.GetObject("Clear.Image")));
            this.Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(38, 22);
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Transfer
            // 
            this.Transfer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Transfer.Image = ((System.Drawing.Image)(resources.GetObject("Transfer.Image")));
            this.Transfer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(41, 22);
            this.Transfer.Text = "Move";
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // Rotate
            // 
            this.Rotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Rotate.Image = ((System.Drawing.Image)(resources.GetObject("Rotate.Image")));
            this.Rotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(45, 22);
            this.Rotate.Text = "Rotate";
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // RotatePoint
            // 
            this.RotatePoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RotatePoint.Image = ((System.Drawing.Image)(resources.GetObject("RotatePoint.Image")));
            this.RotatePoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RotatePoint.Name = "RotatePoint";
            this.RotatePoint.Size = new System.Drawing.Size(85, 22);
            this.RotatePoint.Text = "RotateAround";
            this.RotatePoint.Click += new System.EventHandler(this.RotatePoint_Click);
            // 
            // IntersectionBtn
            // 
            this.IntersectionBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.IntersectionBtn.Image = ((System.Drawing.Image)(resources.GetObject("IntersectionBtn.Image")));
            this.IntersectionBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IntersectionBtn.Name = "IntersectionBtn";
            this.IntersectionBtn.Size = new System.Drawing.Size(76, 22);
            this.IntersectionBtn.Text = "Intersection ";
            this.IntersectionBtn.Click += new System.EventHandler(this.inter_btn_Click);
            // 
            // PolygonBtm
            // 
            this.PolygonBtm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PolygonBtm.Image = ((System.Drawing.Image)(resources.GetObject("PolygonBtm.Image")));
            this.PolygonBtm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PolygonBtm.Name = "PolygonBtm";
            this.PolygonBtm.Size = new System.Drawing.Size(55, 22);
            this.PolygonBtm.Text = "Polygon";
            this.PolygonBtm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.PolygonBtm.Click += new System.EventHandler(this.Polygon_Btn_Click);
            // 
            // rt90_btn
            // 
            this.rt90_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rt90_btn.Image = ((System.Drawing.Image)(resources.GetObject("rt90_btn.Image")));
            this.rt90_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rt90_btn.Name = "rt90_btn";
            this.rt90_btn.Size = new System.Drawing.Size(60, 22);
            this.rt90_btn.Text = "Rotate 90";
            this.rt90_btn.Click += new System.EventHandler(this.rt90_btn_Click_1);
            // 
            // alpha
            // 
            this.alpha.Location = new System.Drawing.Point(39, 44);
            this.alpha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alpha.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(40, 20);
            this.alpha.TabIndex = 2;
            this.alpha.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.alpha.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "α";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "β";
            // 
            // beta
            // 
            this.beta.Location = new System.Drawing.Point(39, 67);
            this.beta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.beta.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.beta.Name = "beta";
            this.beta.Size = new System.Drawing.Size(40, 20);
            this.beta.TabIndex = 4;
            this.beta.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // scale_btn
            // 
            this.scale_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scale_btn.Location = new System.Drawing.Point(9, 149);
            this.scale_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scale_btn.Name = "scale_btn";
            this.scale_btn.Size = new System.Drawing.Size(70, 19);
            this.scale_btn.TabIndex = 6;
            this.scale_btn.Text = "Scale";
            this.scale_btn.UseVisualStyleBackColor = true;
            this.scale_btn.Click += new System.EventHandler(this.scale_btn_Click);
            // 
            // p_scale_btn
            // 
            this.p_scale_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p_scale_btn.Location = new System.Drawing.Point(9, 89);
            this.p_scale_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.p_scale_btn.Name = "p_scale_btn";
            this.p_scale_btn.Size = new System.Drawing.Size(70, 54);
            this.p_scale_btn.TabIndex = 7;
            this.p_scale_btn.Text = "Choose point for scale";
            this.p_scale_btn.UseVisualStyleBackColor = true;
            this.p_scale_btn.Click += new System.EventHandler(this.p_scale_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2129, 1112);
            this.Controls.Add(this.p_scale_btn);
            this.Controls.Add(this.scale_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.beta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alpha);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beta)).EndInit();
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
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown alpha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown beta;
        private System.Windows.Forms.Button scale_btn;
        private System.Windows.Forms.Button p_scale_btn;
        private System.Windows.Forms.ToolStripButton IntersectionBtn;
        private System.Windows.Forms.ToolStripButton PolygonBtm;
        private System.Windows.Forms.ToolStripButton rt90_btn;
    }
}

