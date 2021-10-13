using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AffineTransforms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var a = new Point(2, 2);
            var line = new Point[2] { new Point(1, 1), new Point(3, 3) };
            var result = Polygons.GetRelativePosition(a, line);
           

            a = new Point(5, 3);
            line = new Point[2] { new Point(1, 1), new Point(3, 3) };
            result = Polygons.GetRelativePosition(a, line);
            var r = result;
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
