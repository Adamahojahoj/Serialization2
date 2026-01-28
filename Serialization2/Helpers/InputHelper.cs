using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization2.Helpers
{
    public class InputHelper
    {
        public static string InputText(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static int InputNumber(string prompt)
        {
            Console.WriteLine(prompt);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error! Try again");
            }
            return number;

        }
    }
}
