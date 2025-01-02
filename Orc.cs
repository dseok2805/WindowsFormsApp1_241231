using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_241231
{
    public class Orc : Monster
    {
        public Orc(string name, int hp, int attackPower) : base(name, hp, attackPower)
        {
        }

        public override void Attack()
        {
            System.Console.WriteLine($"{Name} smashes with brute strength, dealing {AttackPower} damage!");
        }

        public override void Talk()
        {
            System.Windows.Forms.MessageBox.Show($"{Name} growls: I will crush you!");
            // Orc 몬스터의 대사를 출력하는 메소드
        }
    }

}
