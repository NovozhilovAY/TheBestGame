using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//test
namespace TheBestGame
{
    class Armor : Item
    {
        //private int id;
        //private Bitmap skin;
        private string name;
        private int defense;
        private int price;

        public Armor()
        {
            name = "test armor";
            defense = 20;
        }
        public Armor(string _name, int _defense)
        {
            name = _name;
            defense = _defense;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }

    class Helmet : Armor
    {
        public Helmet() : base(){}
        public Helmet(string _name, int _defense) : base(_name, _defense) { }


    }
    class Torso : Armor
    {
        public Torso() : base() { }
        public Torso(string _name, int _defense) : base(_name, _defense) { }

    }
    class Leggings : Armor
    {
        public Leggings() : base() { }
        public Leggings(string _name, int _defense) : base(_name, _defense) { }
    }
}
