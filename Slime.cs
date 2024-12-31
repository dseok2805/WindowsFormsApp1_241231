using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_241231
{
    public class Slime : Monster
    {
        public Slime(string name, int hp, int attackPower) : base(name, hp, attackPower)
        {
        }

        public override void Attack()
        {
            System.Console.WriteLine($"{Name} jumps and splashes, dealing {AttackPower} damage!");
        }
    }

}
