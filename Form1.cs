using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace AffineTransforms
{
    public partial class Form1 : Form
    {
        Point beg;
        Point end;
        int mode =0;
        List<Point> points;
        List<Point[]> lines;
        List<Rectangle> rectangles;
        bool mouseDown;

        public Form1()
        {
            InitializeComponent();
            this.points = new List<Point>();
            this.lines = new List<Point[]>();
            this.rectangles = new List<Rectangle>();
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            Pen pen = new Pen(brush);
            Graphics g = e.Graphics;
            foreach (Point point in points)
                g.FillEllipse(brush, point.X, point.Y, 2, 2);
            foreach (var i in lines)
                g.DrawLine(pen, i[0], i[1]);
            foreach (var i in rectangles)
                g.DrawRectangle(pen, i);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            if (mode==0)
            {
                points.Add(new Point(e.X, e.Y)); 
                this.Refresh();
            }
            else
            {
                beg = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            if (mode!=0)
            {
                end = new Point(e.X, e.Y);
                if (mode == 1)
                {
                    var t = new Point[] { beg, end };
                    lines.Add(t);

                }
                else if (mode == 2)
                    rectangles.Add(new Rectangle(Math.Min(beg.X, end.X),
                                                 Math.Min(beg.Y, end.Y),
                                                 Math.Abs(beg.X - end.X),
                                                 Math.Abs(beg.Y - end.Y)
                                                 ));

                else if (mode == 3)
                    MoveImages();

                else if (mode == 4)
                    RotateBase();

                this.Refresh();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
                        
        }

        private void Point_Click(object sender, EventArgs e)
        {
            mode = 0;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            mode = 1;
        }

        private void Square_Click(object sender, EventArgs e)
        {
            mode = 2;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            points.Clear();
            lines.Clear();
            rectangles.Clear();
            this.Refresh();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            mode = 3;
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            RotateBase();
            this.Refresh();
        }

        private void MoveImages()
        {

            Matrix matrix = new Matrix();
            matrix.Translate(-1 * (beg.X - end.X),
                            -1 * (beg.Y - end.Y));
            ApplyMatrix(matrix);

        }

        private void RotateBase()
        {
            Matrix matrix = new Matrix();
            matrix.RotateAt(10,new Point(pictureBox1.Width/2,pictureBox1.Height/2));
            ApplyMatrix(matrix);

        }

        private void ApplyMatrix(Matrix matrix)
        {
            if (points.Count > 0)
            {
                var temp = points.ToArray();
                matrix.TransformPoints(temp);
                points = new List<Point>(temp);
            }

            if (lines.Count > 0)
            {
                var temp = lines.ToArray();
                for (var i = 0; i < lines.Count; i++)
                    matrix.TransformPoints(temp[i]);
                lines = new List<Point[]>(temp);
            }

            if (rectangles.Count > 0)
            {
                for (var i = 0; i < rectangles.Count; i++)
                {
                    var t = rectangles[i].Location;
                    var g = new Point[] { t };
                    matrix.TransformPoints(g);
                    rectangles[i] = new Rectangle(g[0], rectangles[i].Size);
                }
            }
        }
    }
}
