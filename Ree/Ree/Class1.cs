using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ree
{
    public abstract class Calcs
    {
      public abstract  void calcaddition(int x, int y);
        public void multiplication(int a, int b)
        {
            Console.WriteLine(a * b);
           
           
        }
    }

    public class Demos : Calcs
    {
        public override void calcaddition(int x, int y)
        {
            Console.WriteLine(x + y);
          

        }
    }
    internal class Class1
    {

    }
}
