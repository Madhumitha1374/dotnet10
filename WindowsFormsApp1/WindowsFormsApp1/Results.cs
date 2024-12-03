using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Results
    {

        public String Percentage(double maths, double social, double science)
        {
           
                    double result = maths + social + science;
                    double percentage = result / 300 * 100;
                    return Math.Round(percentage,2).ToString();     
            
        }

        public char Grade(int percentage)
        {
            if(percentage > 90 && percentage <= 100)
            {
                return 'A';
            }
            else if (percentage > 80 && percentage <= 90)
            {
                return 'B';
            }
            else if (percentage > 70 && percentage <= 80)
            {
                return 'C';
            }
            else if (percentage > 60 && percentage <= 70)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }

        }
        
    }
}
