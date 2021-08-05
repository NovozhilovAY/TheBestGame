using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestGame
{
    class Damage
    {
        private int result_damage;
        private bool crit;
        public Damage(int _result_damage, bool _crit)
        {
            result_damage = _result_damage;
            crit = _crit;
        }
        public int GetResultDamage()
        {
            return result_damage;
        }
        public bool GetCrit()
        {
            return crit;
        }
    }

    class Weapon : Item
    {
        private int id;
        private Bitmap skin;
        private string name;
        private int min_damage;
        private int max_damage;
        private int crit_damage_chance;
        private double crit_damage_multiplier = 2;
        private int price;

        Random rnd = new Random();

        public Weapon()
        {
            name = "test sword";
            min_damage = 10;
            max_damage = 20;
            crit_damage_chance = 20;
        }
        public Weapon(string _name,
                      int _min_damage,
                      int _max_damage,
                      int _crit_damage_chance)
        {
            name = _name;
            min_damage = _min_damage;
            max_damage = _max_damage;
            crit_damage_chance = _crit_damage_chance;
        }

        public string GetName()
        {
            return name;
        }

        public int GetMinDamage()
        {
            return min_damage;
        }

        public int GetMaxDamage()
        {
            return max_damage;
        }

        public int GetCritChance()
        {
            return crit_damage_chance;
        }

        public double GetCritMultiplier()
        {
            return crit_damage_multiplier;
        }
        public int GetPrice()
        {
            return price;
        }
        public void SetPrice(int _price)
        {
            price = _price;
        }
        public Damage GetDamage()
        {
            int damage = GetNumberFromInterval(min_damage, max_damage);
            bool crit = IsCrit(crit_damage_chance);
            int result_damage = CalculateResultDamage(damage, crit, crit_damage_multiplier);
            return new Damage(result_damage, crit);
        }

        private int GetNumberFromInterval(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }

        private bool IsCrit(int crit_chance)
        {

            int rnd_num = rnd.Next(100 + 1);
            if (rnd_num <= crit_chance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int CalculateResultDamage(int damage, bool crit, double crit_multiplier)
        {
            if (crit)
            {
                double result_damage = damage * crit_multiplier;
                return (int)result_damage;
            }
            else
            {
                return damage;
            }
        }
    }
}
