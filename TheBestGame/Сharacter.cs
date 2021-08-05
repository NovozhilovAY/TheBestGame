using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestGame
{
    class Сharacter
    {
        private int level;
        private int health_points;
        private Weapon weapon;
        private Helmet helmet;
        private Torso torso;
        private Leggings leggings;
        private Shield shield;
        private int defense;

        public Сharacter()
        {
            level = 1;
            health_points = 100;
            weapon = new Weapon();
            helmet = new Helmet();
            torso = new Torso();
            leggings = new Leggings();
            shield = new Shield();
            CalculateDefense();
        }

        public Сharacter(int _level,
                         int _health_points, 
                         Weapon _weapon,
                         Helmet _helmet,
                         Torso _torso,
                         Leggings _leggings,
                         Shield _shield)
        {
            level = _level;
            health_points = _health_points;
            weapon = _weapon;
            helmet = _helmet;
            torso = _torso;
            leggings = _leggings;
            shield = _shield;
            CalculateDefense();
        }

        public int GetLevel()
        {
            return level;
        }

        public int GetHealthPoints()
        {
            return health_points;
        }

        public Weapon GetWeapon()
        {
            return weapon;
        }

        public Helmet GetHelment()
        {
            return helmet;
        }

        public Torso GetTorso()
        {
            return torso;
        }

        public Leggings GetLeggings()
        {
            return leggings;
        }

        public int GetDefense()
        {
            return defense;
        }

        public Shield GetShield()
        {
            return shield;
        }

        public void SetLevel(int _level)
        {
            level = _level;
        }

        public void SetHealthPoints(int _health_points)
        {
            health_points = _health_points;
        }

        public void SetWeapon(Weapon _weapon)
        {
            weapon = _weapon;
        }

        public void SetHelmet(Helmet _helmet)
        {
            helmet = _helmet;
        }

        public void SetTorso(Torso _torso)
        {
            torso = _torso;
        }

        public void SetLeggins(Leggings _leggings)
        {
            leggings = _leggings;
        }

        public void SetShield(Shield _shield)
        {
            shield = _shield;
        }

        private void CalculateDefense()
        {
            defense = helmet.GetDefense() + torso.GetDefense() + leggings.GetDefense();
        }
    }
}
