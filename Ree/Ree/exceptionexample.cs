using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ree
{
    //exception
    public class ExceptionExample
    {
        public void Display() {
        int x1 = 10;
            try
            {
                Console.WriteLine("Division is" + (x1 / 0));
            }

            catch (Exception ex)
            {
                Console.WriteLine("Cannot be divided by zero");
            }
            Console.WriteLine("\nrest of code");
        }
    }
    internal class exceptionexample
    {
    }
}
