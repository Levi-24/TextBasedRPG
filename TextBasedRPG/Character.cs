using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Character
    {
        // Character Info
        public string Name { get; set; }
        public bool Class { get; set; }
        //true = Knight
        //false = Mage
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        // Stats
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Speed { get; set; }
        public int Luck { get; set; }

        // Combat Stats
        public int Defense { get; set; }
        public int MagicDefense { get; set; }

        public int PhysicalDamage { get; set; }
        public int MagicDamage { get; set; }




        public int Accuracy { get; set; }
        public int Evasion { get; set; }

        public int CriticalChance { get; set; }
        public int CriticalDamage { get; set; }

        public int AttackSpeed { get; set; }

        // Inventory
        public int CarryAmount { get; set; }
        public int Gold { get; set; }

        // Skills
        public int SkillPoints { get; set; }
        public int StatPoints { get; set; }
        public string[] Skills { get; set; }
    }
}
