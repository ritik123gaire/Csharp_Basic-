using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ree
{
    public interface Compute1
    {
        void findsum(int x, int y);
        void finddifference(int x, int y);
    }
    public interface Compute2
    {
        void findDivision(int x, int y);
        void findModulo(int x, int y);
    }

    class Practical : Compute1, Compute2
    {
        public void finddifference(int x, int y)
        {
            Console.WriteLine("subtraction: " + (x - y));
        }

        public void findDivision(int x, int y)
        {
            Console.WriteLine("Division: " + (x / y));
        }

        public void findModulo(int x, int y)
        {
            Console.WriteLine("Modulo: " + (x % y));
        }

        public void findsum(int x, int y)
        {
            Console.WriteLine("subtraction: " + (x + y));
        }
    }
    

    internal class multinherit
    {


    }
}
