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
    public partial class FightForm : Form
    {
        Player player1;
        Character fighter1;
        Player player2;
        Character fighter2;
        int player1_max_hp;
        int player2_max_hp;
        public FightForm(Player _player1, Player _player2)
        {
            InitializeComponent();
            player1 = _player1;
            fighter1 = new Character(player1.Character);
            player2 = _player2;
            fighter2 = new Character(player2.Character);
            player1_max_hp = player1.Character.HealthPoints;
            player2_max_hp = player2.Character.HealthPoints;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            Player1NameLabel.Text = player1.Name;
            Player2NameLabel.Text = player2.Name;

            Player1HPLabel.Text = "XP " + fighter1.HealthPoints + " / " + player1_max_hp;
            Player2HPLabel.Text = "XP " + fighter2.HealthPoints + " / " + player2_max_hp;

            Player1DamageLabel.Text = "Урон " + fighter1.Weapon.MinDamage + " - " + fighter1.Weapon.MaxDamage;
            Player2DamageLabel.Text = "Урон " + fighter2.Weapon.MinDamage + " - " + fighter2.Weapon.MaxDamage;

            Player1DefenseLabel.Text = "Защита " + fighter1.Defense;
            Player2DefenseLabel.Text = "Защита " + fighter2.Defense;

            Player1CritChanceLabel.Text = "Шанс крита " + fighter1.Weapon.CritChance;
            Player2CritChanceLabel.Text = "Шанс крита " + fighter2.Weapon.CritChance;

            Player1CritMultLabel.Text = "Множитель крита " + fighter1.Weapon.CritMultiplier;
            Player2CritMultLabel.Text = "Множитель крита " + fighter2.Weapon.CritMultiplier;
        }

        public void UpdateHP()
        {
            Player1HPLabel.Text = "XP " + fighter1.HealthPoints + " / " + player1_max_hp;
            Player2HPLabel.Text = "XP " + fighter2.HealthPoints + " / " + player2_max_hp;
        }

    }
}
