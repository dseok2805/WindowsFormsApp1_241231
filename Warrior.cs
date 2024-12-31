﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_241231
{
    public class Warrior : User
    {
        public Warrior(string name, int hp, int attackPower) : base(name, hp, attackPower)
        {
        }

        public override void Attack()
        {
            System.Console.WriteLine($"{Name} swings a sword, dealing {AttackPower} damage!");
        }

        public override void Defend()
        {
            System.Console.WriteLine($"{Name} raises a shield to block the attack!");
        }
    }

}