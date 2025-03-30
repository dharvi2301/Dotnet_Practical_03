using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03
{
    public class Laptop
    {
        private string brand;
        private string model;

        /// <summary>
        /// Gets or sets the brand of the laptop.
        /// </summary>
        public string Brand
        {
            get { return brand; } 
            set { brand = value; } 
        }

        /// <summary>
        /// Gets or sets the model of the laptop.
        /// </summary>
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        /// <summary>
        /// Displays the laptop details including brand and model.
        /// </summary>
        public void LaptopDetails()
        {
            Console.WriteLine("Brand:" + Brand);
            Console.WriteLine("Model:" + Model);
        }

        /// <summary>
        /// Displays motherboard information (private method, not accessible outside this class).
        /// </summary>
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }
    }
}
