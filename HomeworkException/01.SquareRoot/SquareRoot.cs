using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            string num = Console.ReadLine();
            try
            {
                int numbers = int.Parse(num);
                if (numbers < 0)
                {
                    throw new ArgumentOutOfRangeException("Number cannot be negative!!!");
                }
                int result = (int) Math.Sqrt(numbers);
                Console.WriteLine("Result is {0}", result);
            }
            catch (ArgumentOutOfRangeException are)
            {
                Console.Error.WriteLine("Invalid input: " + are.Message);
                throw;
            }
            catch (FormatException fe)
            {
                Console.Error.WriteLine("Invalid format: " + fe.Message);
            }
            catch (OverflowException oe)
            {
                Console.Error.WriteLine("Input is upper than MaxInt32: " + oe.Message);
            }
            finally
            {
                Console.WriteLine("\nGood bye!");
            }
        }

    }
}
