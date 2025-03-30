using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03
{
    public class Duck:Bird
    {
        /// <summary>
        /// Overrides the Voice method to print the sound made by a duck.
        /// </summary>
        public override void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
