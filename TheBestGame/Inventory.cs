using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestGame
{
    class Inventory
    {
        List<Armor> armors;
        List<Weapon> weapons;

        public Inventory()
        {
            armors = new List<Armor>();
            weapons = new List<Weapon>();
        }
        public List<Armor> GetArmor()
        {
            return armors;
        }
        public List<Weapon> GetWeapon()
        {
            return weapons;
        }

        public void AddToArmor(Armor _armor)
        {
            armors.Add(_armor);
        }
        public void AddToWeapon(Weapon _weapon)
        {
            weapons.Add(_weapon);
        }
        public void RemoveFromArmor(Armor _armor)
        {
            armors.Remove(_armor);
        }
        public void RemoveFromWeapon(Weapon _weapon)
        {
            weapons.Remove(_weapon);
        }
    }
}
