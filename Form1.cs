﻿using System;
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
        List<Point[]> rectangles;
        bool mouseDown;

        public Form1()
        {
            InitializeComponent();
            this.points = new List<Point>();
            this.lines = new List<Point[]>();
            this.rectangles = new List<Point[]>();
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
            {
                g.DrawLine(pen, i[0], i[1]);
                g.DrawLine(pen, i[1], i[2]);
                g.DrawLine(pen, i[2], i[3]);
                g.DrawLine(pen, i[3], i[0]);
            }
            if (mode == 4)
                g.FillEllipse(brush, pictureBox1.Width / 2, pictureBox1.Height / 2,5,5);
            if (mode == 5)
                g.FillEllipse(brush, end.X, end.Y, 5, 5);
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
                    RotateAround(e.Location.X,e.Location.Y);

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
        }

        private void RotatePoint_Click(object sender, EventArgs e)
        {
            mode = 5;
        }
    }
}