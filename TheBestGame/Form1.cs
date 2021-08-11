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
        private Player player;
        public Form1()
        {
            InitializeComponent();
            InitializePlayer();
            InitializeGUI();
        }

        private void InitializePlayer()
        {
            Weapon weapon = new Weapon(1, "King sword", 30, 40, 15);
            Helmet helmet = new Helmet("King helmet", 15);
            Torso torso = new Torso("King cuirass", 30);
            Leggings leggings = new Leggings("King boots", 10);
            Shield shield = new Shield("King shield");
            Character character = new Character(1, 200, weapon, helmet, torso, leggings, shield);
            player = new Player("test", "test", "BossOfThisKingdom", character, new Inventory(), 1000, 0, 10, 10);
        }


        //private void LogDamage(Damage damage)
        //{
        //    int dmg = damage.Result_damage;
        //    bool crit = damage.Crit;
        //    string record = dmg.ToString();
        //    if(crit)
        //    {
        //        record += "  крит!";
        //    }
        //    record += "\r\n";
        //    textBox1.Text = textBox1.Text + record;
        //}
        private void InitializeGUI()
        {
            InitializeWeaponPanel(player.Character.Weapon);
            InitializeArmorPanel(player.Character.Helment, HelmetNameLabel, HelmetDefenseLabel);
            InitializeArmorPanel(player.Character.Torso, TorsoNameLabel, TorsoDefenceLabel);
            InitializeArmorPanel(player.Character.Leggings, LeggingsNameLabel, LeggingsDefenseLabel);
            InitializeShieldPanel(player.Character.Shield);
            NicknameLabel.Text = player.Name;
            LevelLabel.Text = "Уровень: " + player.Character.Level.ToString();
            GoldLabel.Text = "Золото: " + player.Gold;
            DonateGoldLabel.Text = "Изумруды: " + player.Donate_gold;
            HPLabel.Text = "HP " + player.Character.HealthPoints.ToString() + " / " + player.Character.HealthPoints.ToString();
            XPLabel.Text = "XP 0 / 1000!!!";
        }

        private void InitializeWeaponPanel(Weapon weapon)
        {
            WeaponNameLabel.Text = "Название: " + weapon.Name;
            WeaponDamageLabel.Text = "Урон: " + weapon.MinDamage.ToString() + " - " + weapon.MaxDamage.ToString();
            WeaponCritChanceLabel.Text = "Шанс крита: " + weapon.CritChance.ToString() + "%";
            WeaponMultLabel.Text = "Множитель крита: " + weapon.CritMultiplier.ToString();
        }

        private void InitializeArmorPanel(Armor armor, Label NameLabel, Label DefenseLabel)
        {
            NameLabel.Text = "Назване: " + armor.Name;
            DefenseLabel.Text = "Защита: " + armor.Defense.ToString();
        }

        private void InitializeShieldPanel(Shield shield)
        {
            ShieldNameLabel.Text = "Назание: " + shield.Name;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            FightForm fightForm = new FightForm(player, player);
            fightForm.Show();
        }
    }
}
