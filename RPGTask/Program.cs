using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Attack();

            Archer archer = new Archer();
            archer.Attack();

            Mage mage = new Mage();
            mage.Attack();
        }
    }
}