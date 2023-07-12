using System;
using System.ComponentModel.Design;

namespace practiceps1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string strNumber = "123";
            int result;

            if (int.TryParse(strNumber, out result))
            {
                Console.WriteLine("Successfully converted to integer: " + result);
            }
            else
            {
                Console.WriteLine("Failed to convert to integer.");
            }*/
            /* string strNumber = "3.14";
             double result;

             try
             {
                 result = Convert.ToDouble(strNumber);
                 Console.WriteLine("Successfully converted to double: " + result);
             }
             catch (FormatException)
             {
                 Console.WriteLine("Invalid format. Failed to convert to double.");
             }
             catch (OverflowException)
             {
                 Console.WriteLine("Value is too large or too small. Failed to convert to double.");
             }*/
            /*string strNumber = "3.14";
            decimal result;

            try
            {
                result = decimal.Parse(strNumber);
                Console.WriteLine("Successfully converted to decimal: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format. Failed to convert to decimal.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value is too large or too small. Failed to convert to decimal.");
            }*/
            string strNumber = "123";
            int newstring;
            int result;

            if (int.TryParse(strNumber, out result))
            {
                newstring = result*3;
                Console.WriteLine("Successfully converted to integer: " + result);

            }
            else
            {
                if(strNumber== "123")
                {
                    newstring = strNumber * 3;
                }
            }
            else
            {
                Console.WriteLine("Failed to convert to integer.");
            }
            Console.ReadKey();

        }
    }
}