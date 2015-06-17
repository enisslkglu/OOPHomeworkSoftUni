using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            List<int> nums = new List<int>();
            
            while (nums.Count < 10)
            {
                nums.Add(ReadNumbers(1, 100));
            }
            nums.Sort();
            Console.WriteLine("Numbers;");
            Console.WriteLine(string.Join(", ", nums));
            
        }

        private static int ReadNumbers(int start, int end)
        {
            int numbers;
            while (true)
            {
                try
                {
                    numbers = int.Parse(Console.ReadLine());
                    if (numbers <= start || numbers >= end)
                    {
                        throw new ArgumentOutOfRangeException("Number must be between 0 and 100!!!");
                    }
                    return numbers;
                }
                catch (ArgumentOutOfRangeException are)
                {
                    Console.Error.WriteLine("Input must be between \"0\" and \"100\"!" + are.Message);
                }
                catch (FormatException fe)
                {
                    Console.Error.WriteLine("Invalid format!" + fe.Message);
                }
                
            }
            
        }
    }
}
