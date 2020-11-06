using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string outp = "";           

            while (string.IsNullOrEmpty(outp))
            {
                Console.WriteLine(message);
                outp = Console.ReadLine();
            }

            return outp;
        }

        public static int RequestInt(this string message, int minVal, int maxVal)
        {
            return message.RequestInt(true, minVal, maxVal);
        }

        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }

        private static int RequestInt(this string message, bool useMinMax, int minVal = 0, int maxVal = 0)
        {
            int i = 0;
            bool isValidInt = false;
            bool isInValidRange = true;

            while (!isValidInt || !isInValidRange)
            {
                Console.WriteLine(message);
                isValidInt = int.TryParse(Console.ReadLine(), out i);

                if (useMinMax)
                {
                    isInValidRange = (i >= minVal && i <= maxVal);
                    //{
                    //    isInValidRange = true;
                    //}
                    //else
                    //{
                    //    isInValidRange = false;
                    //}
                }
            
            }
            if (i < 0)
            {
                return 0;
            }
            else
            {
                return i;
            }
        }
    }
}
