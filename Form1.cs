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
        Point scalePoint;
        int mode =0;
        List<Point> points;
        List<Point[]> lines;
        List<Point[]> rectangles;
        List<List<Point>> polygons;
        int prevMode = 0;
        Point[] secondLine;
        bool mouseDown;
        double alphaPred = 0.0;
        double betaPred = 0.0;

        public Form1()
        {
            InitializeComponent();
            this.points = new List<Point>();
            this.lines = new List<Point[]>();
            this.rectangles = new List<Point[]>();
            this.DoubleBuffered = true;
            this.polygons = new List<List<Point>>();
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
            {
                g.DrawLine(pen, i[0], i[1]);
                g.DrawLine(pen, i[1], i[2]);
                g.DrawLine(pen, i[2], i[3]);
                g.DrawLine(pen, i[3], i[0]);
            }
            foreach(var p in polygons)
            {
                for(int i = 0; i < p.Count-1; i++)
                {
                    g.DrawLine(pen, p[i], p[i + 1]);
                }
                if(!(p==polygons.Last() && mode == 8))
                {
                    g.DrawLine(pen, p.First(), p.Last());
                }
               
            }
            if (mode == 4)
                g.FillEllipse(brush, pictureBox1.Width / 2, pictureBox1.Height / 2,5,5);
            if (mode == 5)
                g.FillEllipse(brush, end.X, end.Y, 5, 5);
            if(mode == 7)
            {
                g.DrawLine(pen, secondLine[0], secondLine[1]);
                var interPoint = Helpers.IntersectionPoint(lines[0][0], lines[0][1], secondLine[0], secondLine[1]);
                g.FillEllipse(new SolidBrush(Color.Black), interPoint.X - 5, interPoint.Y - 5, 10, 10);
                if (interPoint.X >= Math.Min(secondLine[0].X, lines[0][0].X) 
                    && interPoint.X <= Math.Max(secondLine[1].X, lines[0][1].X) 
                    && interPoint.Y >= Math.Min(secondLine[0].Y, lines[0][0].Y)
                    && interPoint.Y <= Math.Max(secondLine[1].Y, lines[0][1].Y)
                    )
                    MessageBox.Show("Ребра не пересекаются");
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            if (mode==0)
            {
                points.Add(new Point(e.X, e.Y)); 
                this.Refresh();
            }
            if (mode == 8)
            {
                polygons.Last().Add(new Point(e.X, e.Y));
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
                {
                    var first = new Point(Math.Min(beg.X, end.X), Math.Max(beg.Y, end.Y));
                    var second = new Point(Math.Min(beg.X, end.X), Math.Min(beg.Y, end.Y));
                    var third = new Point(Math.Max(beg.X, end.X), Math.Min(beg.Y, end.Y));
                    var fourth = new Point(Math.Max(beg.X, end.X), Math.Max(beg.Y, end.Y));

                    rectangles.Add(new Point[] { first, second, third, fourth });
                }

                else if (mode == 3)
                    MoveImages();

                else if (mode == 5)
                    RotateAround(e.Location.X, e.Location.Y);
                else if (mode == 6)
                {
                    scalePoint = new Point(e.X, e.Y);
                    scale_btn.Enabled = true;
                }
                else if(mode == 7)
                {
                    secondLine = new Point[] { beg, end };

                } 
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
            polygons.Clear();
            this.Refresh();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            mode = 3;
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            mode = 4;
            RotateAround(pictureBox1.Width / 2, pictureBox1.Height / 2);
            this.Refresh();
        }

        private void MoveImages()
        {

            Matrix matrix = new Matrix();
            matrix.Translate(-1 * (beg.X - end.X),
                            -1 * (beg.Y - end.Y));
            ApplyMatrix(matrix);

        }

        private void RotateAround(int wid, int heigh)
        {
            Matrix matrix = new Matrix();
            matrix.RotateAt(10, new Point(wid, heigh));
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
                var temp = rectangles.ToArray();
                for (var i = 0; i < rectangles.Count; i++)
                    matrix.TransformPoints(temp[i]);
                rectangles = new List<Point[]>(temp);
            }

            if (polygons.Count > 0)
            { 
              var temp = polygons.Select(p=>p.ToArray()).ToArray();
              for (var i = 0; i < polygons.Count; i++)
                     matrix.TransformPoints(temp[i]);
              polygons = new List<List<Point>>(temp.Select(a=>new List<Point>(a)));    
            }
        }

        private void RotatePoint_Click(object sender, EventArgs e)
        {
            mode = 5;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void scale_btn_Click(object sender, EventArgs e)
        {
            var a = (double)alpha.Value / 100.0;
            var b = (double)beta.Value / 100.0;

            var rect = rectangles[0];
            for (int i = 0; i < rect.Length; i++)
            {
                var result = Helpers.Scale(a, b, rect[i], scalePoint);
                rect[i] = new Point((int)result[0, 0], (int)result[0, 1]);
            }
            rectangles[0] = rect;
            alphaPred = a;
            betaPred = b;
            this.Refresh();
        }

        private void p_scale_btn_Click(object sender, EventArgs e)
        {
            mode = 6;
        }

        private void inter_btn_Click(object sender, EventArgs e)
        {
            mode = 7;
        }

        private void Polygon_Btn_Click(object sender, EventArgs e)
        {
            if (mode != 8)
            {
                prevMode = mode;
                mode = 8;
                polygons.Add(new List<Point>());
            }
            else
            {
                mode = prevMode;
                this.Refresh();
            }
        }

    }
}
