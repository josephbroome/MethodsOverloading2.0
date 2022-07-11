using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading2._0
{
    internal class Methods
    {
        public static double Add(double x, double y)
        {

            return x + y;

        }

        public static double Add(double x, double y, double z)
        {
            return x + y + z;


        }


        public static string Add(double num1, double num2, bool isCheck)
        {
            var sum = num1 + num2;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";

            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";

            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }


        }




    }
}
