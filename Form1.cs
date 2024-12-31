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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Initialize form settings here
        }

        private void Battle(Character player, Character monster)
        {
            // Display battle messages in a message box
            MessageBox.Show($"Battle starts between {player.Name} and {monster.Name}!", "Battle Start");
            MessageBox.Show($"{player.Name} attacks!", "Player Attack");
            player.Attack();
            MessageBox.Show($"{monster.Name} attacks!", "Monster Attack");
            monster.Attack();
        }

        private void buttonBattle_Click(object sender, EventArgs e)
        {
            // Wizard, Warrior, Orc, Slime 객체를 생성
            // Create characters
            Wizard player1 = new Wizard("Gandalf", 100, 30);
            Warrior player2 = new Warrior("Aragorn", 120, 25);
            // Wizard, Warrior 등 캐릭터를 생성
            Orc monster1 = new Orc("Uruk-hai", 150, 20);
            Slime monster2 = new Slime("Slimey", 50, 10);

            // Perform battles
            Battle(player1, monster1);
            Battle(player2, monster2);
            // Battle 메서드는 각 캐릭터의 Attack() 메서드를 호출하여 행동을 출력
        }
    }
}
