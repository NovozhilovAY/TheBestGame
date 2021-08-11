using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestGame
{
    class Shield : Item
    {
        private string name;

        public Shield()
        {
            name = "Shield";
        }

        public Shield(string _name)
        {
            name = _name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
    }
}
