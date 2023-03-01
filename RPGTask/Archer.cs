using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTask
{
    public class Archer : Unit
    {
        public int ShootingSpeed { get; set; } = 50;

        public override int Health { get; set; } = 70;

        public override void Attack()
        {
            Console.WriteLine($"Archer is shooting! Shooting speed: {ShootingSpeed}, Health: {Health}");
        }
    }
}
