using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace AffineTransforms
{
    class Helpers
    {
        static public double[,] MultiplyMatrix(double[,] A, double[,] B)
        {
            int rA = A.GetLength(0);
            int cA = A.GetLength(1);
            int rB = B.GetLength(0);
            int cB = B.GetLength(1);
            double temp = 0;
            double[,] kHasil = new double[rA, cB];
            if (cA != rB)
            {
                Console.WriteLine("matrix can't be multiplied !!");
            }
            else
            {
                for (int i = 0; i < rA; i++)
                {
                    for (int j = 0; j < cB; j++)
                    {
                        temp = 0;
                        for (int k = 0; k < cA; k++)
                        {
                            temp += A[i, k] * B[k, j];
                        }
                        kHasil[i, j] = temp;
                    }
                }
                return kHasil;
            }
            return null;
        }
        static public double[,] Scale(double alpha, double beta, Point point, Point scalePoint)
        {
            int x = scalePoint.X, y = scalePoint.Y;
            double[,] scale = {
                { alpha, 0, 0 },
                { 0, beta, 0 },
                { (1-alpha) * x, (1-beta) *  y, 1 } };
            double[,] matr = { { point.X, point.Y, 1 } };
            var result = MultiplyMatrix(matr, scale);
            return result;
        }

        static public (int A, int B, int C) LineEquation(Point a, Point b)
        {
            int A = b.Y - a.Y;
            int B = a.X - b.X;
            int C = b.X * a.Y - a.X * b.Y;
            return (A, B, C);

        }

        static public Point IntersectionPoint(Point a, Point b, Point c, Point d)
        {
            var eq1 = LineEquation(a, b);
            var eq2 = LineEquation(c, d);
            if ((eq1.A * eq2.B - eq2.A * eq1.B) == 0)
                return new Point();
            var det1 = eq1.A * eq2.C - eq2.A * eq1.C;
            var det2 = eq1.B * eq2.C - eq2.B * eq1.C;
            if (det1 == 0 && det2 == 0)
                return new Point();
            int x = -(eq1.C * eq2.B - eq2.C * eq1.B) / (eq1.A * eq2.B - eq2.A * eq1.B);
            int y = -(eq1.A * eq2.C - eq2.A * eq1.C) / (eq1.A * eq2.B - eq2.A * eq1.B);
            return new Point(x, y);
        }

    }
}
