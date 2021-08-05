using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestGame
{
    public partial class Form1 : Form
    {
        Weapon test_weapon;

        Helmet test_helmet;
        Torso test_torso;
        Leggings test_leggings;
        Weapon weapon1;

        public Form1()
        {
            InitializeComponent();
            test_weapon = new Weapon();

            test_helmet = new Helmet();
            test_torso = new Torso();
            test_leggings = new Leggings();
            InitializeWeaponPanel(test_weapon);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Damage dmg = test_weapon.GetDamage();
            //var a = test_weapon.GetType();
            //var aa = test_helmet.GetType();
            //Armor ass = new Helmet();
            //var s = a.Name;
            //var ss = aa.Name;
            //var assss = ass.GetType();

            LogDamage(dmg);
        }

        private void LogDamage(Damage damage)
        {
            int dmg = damage.GetResultDamage();
            bool crit = damage.GetCrit();
            string record = dmg.ToString();
            if(crit)
            {
                record += "  крит!";
            }
            record += "\r\n";
            textBox1.Text = textBox1.Text + record;
        }

        private void InitializeWeaponPanel(Weapon weapon)
        {
            label1.Text = "Название: " + weapon.GetName();
            label2.Text = "Урон: " + weapon.GetMinDamage().ToString() + " - " + weapon.GetMaxDamage().ToString();
            label3.Text = "Шанс крита: " + weapon.GetCritChance().ToString() + "%";
            label4.Text = "Множитель крита: " + weapon.GetCritMultiplier().ToString();
        }   
    }
}
