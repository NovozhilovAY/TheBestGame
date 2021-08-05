using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestGame
{
    class Shield
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
        public string GetName()
        {
            return name;
        }
        public void SetName(string _name)
        {
            name = _name;
        }
    }
}
