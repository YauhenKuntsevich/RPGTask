using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTask
{
    public class Mage : Unit
    {
        public int SpellForce { get; set; } = 10;

        public override int Health { get; set; } = 50;

        public override void Attack()
        {
            Console.WriteLine($"Mage if doing magic! Spell force: {SpellForce}, Health: {Health}");
        }
    }
}
