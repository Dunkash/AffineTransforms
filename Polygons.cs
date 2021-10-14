using System;
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
        public static float GetRelativePosition(PointF b, PointF[] line)
        {
            if (line.Count() != 2)
            {
                throw new ArgumentException("Line should contains 2 points!");
            }
            Matrix matrix = new Matrix();
            matrix.Translate(-line[0].X, -line[0].Y);
            var points = new PointF[2] { b, line[1] };
            matrix.TransformPoints(points);
            b = points[0];
            var a = points[1];
            var result= b.Y * a.X - b.X * a.Y;
            return result;
        }


        public static bool IsBelongsToConvexPolygon(PointF point, List<PointF> polygon)
        {
            List<PointF[]> lines = new List<PointF[]>();
            for (var i = 0; i < polygon.Count() - 1; i++)
            {
                lines.Add(new PointF[2] { polygon[i], polygon[i + 1] });
            }
            lines.Add(new PointF[2] { polygon.Last(), polygon.First() });
            var firstCheck = Polygons.GetRelativePosition(point, lines[0]);
            for (var i = 1; i < polygon.Count(); i++)
            {
                if (firstCheck * Polygons.GetRelativePosition(point, lines[i]) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsBelongsToPolygon(PointF point, List<PointF> polygon)
        {
            List<PointF[]> lines = new List<PointF[]>();
            Matrix matrix = new Matrix();
            matrix.Translate(-point.X, -point.Y);
            for (var i = 0; i < polygon.Count() - 1; i++)
            {
                lines.Add(new PointF[2] { polygon[i], polygon[i + 1] });
                matrix.TransformPoints(lines[i]);
            }
            lines.Add(new PointF[2] { polygon.Last(), polygon.First() });
            matrix.TransformPoints(lines.Last());
            var anglesSum = 0.0;
            for (var i = 0; i < lines.Count(); i++)
            {
                var p1 = lines[i][0];
                var p2 = lines[i][1];
                var scalarProd =  p1.X*p2.X + p1.Y*p2.Y;
                var cos = scalarProd / (Length(p1) * Length(p2));
                anglesSum += Math.Acos(cos) * Math.Sign(p1.X*p2.Y-p1.Y*p2.X);
            }
            return !(Math.Abs(anglesSum)<0.00000001);
        }



        public static double Length(PointF p)
        {
            return Math.Sqrt(Math.Pow(p.X, 2) + Math.Pow(p.Y, 2));

        }

        public static PointF GetCenterPoint(PointF[] points)
        {
            float sumX = 0, sumY = 0;
            foreach (var p in points)
            {
                sumX += p.X;
                sumY += p.Y;
            }
            return new PointF((int)(sumX * 1.0 / points.Length * 1.0), (int)(sumY * 1.0 / points.Length * 1.0));
        }

    }



  
}
