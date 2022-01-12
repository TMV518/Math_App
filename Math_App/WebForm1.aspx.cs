using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Math_App
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(tb1.Text);
                double y1 = double.Parse(tb2.Text);
                double x2 = double.Parse(tb3.Text);
                double y2 = double.Parse(tb4.Text);

                (double, double) midpoint = Midpoint(x1, y1, x2, y2);
                double radius = Radius(x1, y1, x2, y2);
                string equation = Equation(midpoint, radius);


                eqLab.Text = equation;
                midLab.Text = "Midpoint " + midpoint;
                radLab.Text = "Radius: " + radius;
            } catch (Exception n)
            {

            }
            /*if (!double.TryParse(tb1.Text, out double a) || !double.TryParse(tb2.Text, out double b)
                || !double.TryParse(tb3.Text, out double c) || !double.TryParse(tb4.Text, out double d))
            {

            }
            else
            {
                double x1 = double.Parse(tb1.Text);
                double y1 = double.Parse(tb2.Text);
                double x2 = double.Parse(tb3.Text);
                double y2 = double.Parse(tb4.Text);

                (double, double) midpoint = Midpoint(x1, y1, x2, y2);
                double radius = Radius(x1, y1, x2, y2);
                string equation = Equation(midpoint, radius);


                eqLab.Text = equation;
                midLab.Text = "Midpoint " + midpoint;
                radLab.Text = "Radius: " + radius;
            }*/

        }

        //finding equation from endpoints
        static (double, double) Midpoint(double x1, double y1, double x2, double y2)
        {

            //finding midpoint
            double mid1 = (x1 + x2) / 2;
            double mid2 = (y1 + y2) / 2;

            (double, double) midpoint = (mid1, mid2);

            return midpoint;
        }

        static double Radius(double x1, double y1, double x2, double y2)
        {
            double distance;
            double diff1 = x2 - x1;
            double diff2 = y2 - y1;

            distance = Math.Sqrt(Math.Pow(diff1, 2) + Math.Pow(diff2, 2));

            double radius = distance / 2;

            return radius;
        }

        static string Equation((double, double) midpoint, double radius)
        {
            string h = midpoint.Item1.ToString();
            string k = midpoint.Item2.ToString();
            string rSquared = Math.Pow(radius, 2).ToString();

            string part1 = "(x-", part2 = "(y-";
            if (midpoint.Item1 < 0)
            {
                part1 = "(x+";
                h = Math.Abs(midpoint.Item1).ToString();
            }
            if (midpoint.Item2 < 0)
            {
                part2 = "(y+";
                k = Math.Abs(midpoint.Item2).ToString();
            }

            string eq = part1 + h + ")² + " + part2 + k + ")² = " + rSquared;

            return eq;
        }
    }
}