using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_241231
{
    public partial class buttonLevelUp : Form
    {
        private Wizard player1;
        private Warrior player2;
        private Orc monster1;
        private Slime monster2;

        public buttonLevelUp()
        {
            InitializeComponent();
            InitializeCharacters();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Update the initial UI
            UpdateUI();
        }

        private void InitializeCharacters()
        {
            // Initialize characters
            player1 = new Wizard("Gandalf", 100, 30);
            player2 = new Warrior("Aragorn", 120, 25);
            monster1 = new Orc("Uruk-hai", 150, 20);
            monster2 = new Slime("Slimey", 50, 10);
        }

        private void UpdateUI()
        {
            // Update the HP and labels
            labelPlayer1HP.Text = $"Gandalf HP: {player1.HP}, Power: {player1.AttackPower}";
            labelPlayer2HP.Text = $"Aragorn HP: {player2.HP}, Power: {player2.AttackPower}";
            labelMonster1HP.Text = $"Uruk-hai HP: {monster1.HP}";
            labelMonster2HP.Text = $"Slimey HP: {monster2.HP}";

            progressBarPlayer1.Value = Math.Max(player1.HP, 0);
            progressBarPlayer2.Value = Math.Max(player2.HP, 0);
            progressBarMonster1.Value = Math.Max(monster1.HP, 0);
            progressBarMonster2.Value = Math.Max(monster2.HP, 0);
        }

        private void Battle(Character attacker, Character defender)
        {
            if (defender.HP <= 0)
            {
                MessageBox.Show($"{defender.Name} has already been defeated!", "Battle");
                return;
            }

            MessageBox.Show($"{attacker.Name} attacks {defender.Name}!", "Battle");
            defender.HP -= attacker.AttackPower;

            if (defender.HP <= 0)
            {
                MessageBox.Show($"{defender.Name} has been defeated!", "Battle");
            }

            UpdateUI();
        }

        private void buttonBattle_Click(object sender, EventArgs e)
        {
            // Perform multiple battles
            Battle(player1, monster1);
            Battle(monster1, player1);
            Battle(player2, monster2);
            Battle(monster2, player2);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Reset the characters and UI
            InitializeCharacters();
            UpdateUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Demonstrate LevelUp method
            player1.LevelUp(20); // Increase only HP
            player2.LevelUp(15, 10); // Increase HP and Attack Power
            player1.LevelUp(); // Error case (no parameters provided)

            UpdateUI();
        }
    }       
}
