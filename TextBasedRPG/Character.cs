using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Character
    {
        // New Character
        public Character(string name, string[] statusEffects)
        {
            Name = name;
            Level = 0;
            Experience = 0;
            Health = 100;
            Stamina = 100;
            StatusEffects = statusEffects;
            Strength = 10;
            Speed = 7;
            Luck = 3;
            Damage = Strength * 3;
            Accuracy = Strength * Speed;
            Evasion = Speed * Luck;
            CriticalChance = Luck * 3;
            CriticalDamage = Strength * 3;
            Gold = 12;
            StatPoints = 0;
        }

        // Load Character
        public Character(string line)
        {
            var pieces = line.Split(';');
            Name = pieces[0];
            Level = int.Parse(pieces[1]);
            Experience = int.Parse(pieces[2]);
            Health = int.Parse(pieces[3]);
            Stamina = int.Parse(pieces[4]);
            StatusEffects = pieces[5].Split(',');
            Strength = int.Parse(pieces[6]);
            Speed = int.Parse(pieces[7]);
            Luck = int.Parse(pieces[8]);
            Damage = Strength * 3;
            Accuracy = Strength * Speed;
            Evasion = Speed * Luck;
            CriticalChance = Luck * 3;
            CriticalDamage = Strength * 3;
            Gold = int.Parse(pieces[9]);
            StatPoints = int.Parse(pieces[10]);
        }

        // Character Info
        public string Name { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        public string[] StatusEffects { get; set; }
        public int Gold { get; set; }
        public int StatPoints { get; set; }

        // Stats
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Luck { get; set; }

        // Combat Stats
        public int Damage { get; set; }
        public int Accuracy { get; set; }
        public int Evasion { get; set; }
        public int CriticalChance { get; set; }
        public int CriticalDamage { get; set; }
    }
}
