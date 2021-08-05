﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//test
namespace TheBestGame
{
    class Armor
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
        public string GetName()
        {
            return name;
        }

        public int GetDefense()
        {
            return defense;
        }
        public void SetName(string _name)
        {
            name = _name;
        }

        public void SetDefense(int _defense)
        {
            defense = _defense;
        }

        public int GetPrice()
        {
            return price;
        }
        public void SetPrice(int _price)
        {
            price = _price;
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
