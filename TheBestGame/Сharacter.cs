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
                         Shield _shield
                         )

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

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int HealthPoints
        {
            get { return health_points; }
            set { health_points = value; }
        }

        public Weapon Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public Helmet Helment
        {
            get { return helmet; }
            set { helmet = value; }
        }

        public Torso Torso
        {
            get{ return torso; }
            set { torso = value; }
        }

        public Leggings Leggings
        {
            get{ return leggings; }
            set{ leggings = value; }
        }

        public int Defense
        {
            get { return defense; }
        }

        public Shield Shield
        {
            get{ return shield; }
            set { shield = value; }
        }

        private void CalculateDefense()
        {
            defense = helmet.Defense + torso.Defense + leggings.Defense;
        }
    }
}
