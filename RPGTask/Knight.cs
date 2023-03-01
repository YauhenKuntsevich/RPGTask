using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTask
{
    public class Knight : Unit
    {
        public int AttackForce { get; set; } = 20;

        public override int Health { get; set; } = 100;

        public override void Attack()
        {
            Console.WriteLine($"Knight is hitting! Force: {AttackForce}, Health: {Health}");
        }
    }
}
