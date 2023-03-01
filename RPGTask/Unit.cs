using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTask
{
    public abstract class Unit
    {
        public abstract int Health { get; set; }

        public abstract void Attack();
    }
}
