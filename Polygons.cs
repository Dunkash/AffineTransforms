﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AffineTransforms
{
    public class Polygons
    {
        public static int GetRelativePosition(Point b, Point[] line)
        {
            if (line.Count() != 2)
            {
                throw new ArgumentException("Line should contains 2 points!");
            }
            Matrix matrix = new Matrix();
            matrix.Translate(-line[0].X, -line[0].Y);
            var points = new Point[2] { b, line[1] };
            matrix.TransformPoints(points);
            b = points[0];
            var a = points[1];
            var result= b.Y * a.X - b.X * a.Y;
            return result;
        }
    }
}
