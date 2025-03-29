using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Inheritance
            Team myTeam = new Team();
            Console.WriteLine(myTeam.PrintInfo());

            //Polymorphism
            Bird myBird= new Bird();
            // Following line gives error since this is not possible
            //Duck myDuck= new Bird(); 
            myBird.Voice();
            //myDuck.Voice();

            //Abstraction
            Laptop myLaptop= new Laptop();
            myLaptop.Brand = "Dell";
            myLaptop.Model = "Inspiron 14";
            myLaptop.LaptopDetails();
            // The following line will give an error because private method is not accessible from outside the class
            //myLaptop.MotherBoardInfo();

            Console.ReadLine();
        }
    }
}
