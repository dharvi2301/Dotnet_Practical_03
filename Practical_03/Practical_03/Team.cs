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

        public string PrintInfo()
        {
            return owner + " " + "Sponsor";
        }
    }
}
