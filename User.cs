using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_241231
{
    public abstract class User : Character
    {
        public User(string name, int hp, int attackPower) : base(name, hp, attackPower)
        {
        }

        public abstract void Defend();

        // LevelUp method overloads
        public void LevelUp(int hp)
        {
            HP += hp;
            System.Windows.Forms.MessageBox.Show($"{Name} leveled up! HP increased by {hp}. New HP: {HP}");
        }

        public void LevelUp(int hp, int power)
        {
            HP += hp;
            AttackPower += power;
            System.Windows.Forms.MessageBox.Show($"{Name} leveled up! HP increased by {hp} and Attack Power increased by {power}. New HP: {HP}, New Attack Power: {AttackPower}");
        }

        public void LevelUp()
        {
            System.Windows.Forms.MessageBox.Show($"Error: No level-up parameters provided for {Name}. Please specify HP or HP and Attack Power.", "Level Up Error");
        }
    }

}
