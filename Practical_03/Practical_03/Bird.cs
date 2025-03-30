using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03
{
    public class Bird
    {
        /// <summary>
        /// Prints the sound made by a generic bird.
        /// </summary>
        public virtual void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }
}
