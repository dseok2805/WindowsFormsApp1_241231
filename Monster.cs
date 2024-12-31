using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_241231
{
    public abstract class Monster : Character
    {
        public Monster(string name, int hp, int attackPower) : base(name, hp, attackPower)
        {
        }
    }

}
