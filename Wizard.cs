using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_241231
{
    public class Wizard : User
    {
        public Wizard(string name, int hp, int attackPower) : base(name, hp, attackPower)
        {
        }

        public override void Attack()
        {
            System.Console.WriteLine($"{Name} casts a spell, dealing {AttackPower} damage!");
        }

        public override void Defend()
        {
            System.Console.WriteLine($"{Name} uses a magical shield to defend!");
        }

        public override void Talk()
        {
            System.Windows.Forms.MessageBox.Show($"{Name} says: I am Wizard!");
            // 마법사의 대사를 출력하는 메소드
        }
    }

}
