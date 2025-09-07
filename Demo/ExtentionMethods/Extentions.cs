using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ExtentionMethods
{
    public static class Extentions
    {

        public static int Reverse(this int number)
        {
            int reversedNumber = 0;
            int Reminder;
            while(number != 0)
            {
                Reminder = number % 10;
                reversedNumber = reversedNumber * 10 + Reminder;
                number /= 10;
            }
            return reversedNumber;
        }



    }
}
