using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowExc
{
    class ReadNumberMehod
    {
        public static int ReadNumber(int start, int end, int i)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number < start) || (number > end) || (number < i))
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }
        static void Main(string[] args)
        {

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                {
                    for (int i = 1; i <= 10; i++)
                    {

                        Console.WriteLine("Enter number {0} in the range [{1}...{2}] : ", i, 1, 10);
                        int number1 = ReadNumber(1, 10, i);
                    }
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("the number is not an integer");

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("the number is not an integer");
            }
            catch (OverflowException)
            {
                Console.WriteLine("the number is not in the range of an integer");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("the number is not in the range");
            }



            }
    }
}
