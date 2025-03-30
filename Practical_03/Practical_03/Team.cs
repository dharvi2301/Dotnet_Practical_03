using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03
{
    public class Team:Sponsor
    {
        private string teamName;

        /// <summary>
        /// Returns the sponsor information.
        /// </summary>
        /// <returns>String containing the sponsor name.</returns>
        public string PrintInfo()
        {
            return owner + " " + "Sponsor";
        }
    }
}
