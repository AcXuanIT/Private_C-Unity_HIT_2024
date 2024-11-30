using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameTerminal02
{
    internal class Weapon
    {
        private string name;
        private int damage;
        private int rangeAttack;

        public Weapon(string name, int damage, int rangeAttack)
        {
            this.name = name;
            this.damage = damage;
            this.rangeAttack = rangeAttack;
        }
        public int range
        {
            get
            {
                return this.rangeAttack;
            }
        }
        public string nameWeapon
        {
            get
            {
                return this.name;
            }
        }
    } 
}
