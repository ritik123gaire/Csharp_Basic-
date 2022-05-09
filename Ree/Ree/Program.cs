using System;


namespace Ree
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Demos d1 = new Demos();
            d1.calcaddition(5, 10);
            d1.multiplication(10, 2);

            //
            Calcs c1;
            c1 = d1;
            c1.calcaddition(50, 10);
            c1.multiplication(100, 2);
           

            //object multiinherit

            Practical p1 = new Practical();
            p1.findsum(1, 2);
            p1.findDivision(20, 10);
            p1.findModulo(20, 10);
            p1.finddifference(16, 10);
            

            Compute1 ca1;
            ca1 = p1;
            Console.WriteLine("Compute 1");
            ca1.findsum(1, 2);
            ca1.finddifference(20, 10);
            

            Compute2 ca2;
            ca2 = p1;
            Console.WriteLine("Compute 2");
            ca2.findDivision(20, 10); 
            ca2.findModulo(20, 10);
            
            //get set propertyy
            PropertyExample example = new PropertyExample();
            example.Num1 = 2;
            example.Num2 = 3;
            
            Console.WriteLine(example.Num1);
            Console.WriteLine(example.Num2);
            example.sum();
           

            //Prado CAr Multilevel Inheritence

            Prado prado1 = new Prado();
            prado1.Brand = "Toyota";
            prado1.Model = "S11";
            
            prado1.Gear = 6;
            prado1.Speed = 220;

            Console.WriteLine("The model of prado is : "+prado1.Model);
            Console.WriteLine("The brand of prado is : " + prado1.Brand);
            Console.WriteLine("The speed of prado is : " + prado1.Speed);
            Console.WriteLine();
            

            FourWheelDrive fourWheelDrive = new FourWheelDrive();
            fourWheelDrive.Brand = "Mahindra";
            fourWheelDrive.Model = "Thar";
            fourWheelDrive.Gear = 7;
            
            //fourWheelDrive.Speed = 150; as grand child cant be access by parent class
            Console.WriteLine("The model of thar is : " + fourWheelDrive.Model);
            Console.WriteLine("The brand of thar is : " + fourWheelDrive.Brand);
            Console.WriteLine("The gear of thar is : " + fourWheelDrive.Gear);
            Console.WriteLine();

            //Exception
            ExceptionExample divide = new ExceptionExample();
            divide.Display();
            Console.ReadLine();

            
        }
    }
}