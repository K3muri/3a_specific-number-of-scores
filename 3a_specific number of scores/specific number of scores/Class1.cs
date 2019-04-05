using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specific_number_of_scores
{
    public class limited
    {
        public static double Limiter(double x)
        {
           
            if (x < 0 || x > 100)
            {
                Console.WriteLine("ensure your value is from 0 to 100");
                x = double.Parse(Console.ReadLine());
            }
            return x;
            
        }


       
    public static double grades(double a, double b, double c, double d, double e, double f, double g, double h, double i, double j)
        {
            return (a + b + c + d + e + f + g + h + i + j);
        }

        public static double average(double x)
        {
            return x / 10;
        }

        public static char letterGrade(double x)
        {

            if (x >= 90.0)
            {
                return 'A';
            }

            if (x >= 80.0)
            {
                return 'B';
            }

            if (x >= 70.0)
            {
                return 'C';
            }

            if (x >= 60.0)
            {
                return 'D';
            }

            return 'F';

        }
    }
}