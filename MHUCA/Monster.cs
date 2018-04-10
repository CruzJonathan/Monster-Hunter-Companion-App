using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHUCA
{


    public class Monster
    {
        public Monster(string Name, string Species, string Location, string ElementalWeakness, string AilmentWeakness, string Resistances, string BreakSever, string RewardsLow, string RewardsHigh)
        {
            this.MonsterName = Name;
            this.MonsterSpecies = Species;
            this.MonsterLocation = Location;
            this.MonsterElementalWeakness = ElementalWeakness;
            this.MonsterAilmentWeakness = AilmentWeakness;
            this.MonsterResistances = Resistances;
            this.MonsterBreakSever = BreakSever;
            this.MonsterRewardsLow = RewardsLow;
            this.MonsterRewardsHigh = RewardsHigh;
        }

        public static List<Monster> Monsters
        {
            get
            {
                List<Monster> monsters = new List<Monster>();
                monsters.Add(new Monster("Anjanath", "Brute Wyvern", "Ancient Forest, Wildspire Waste",
                "Water, Thunder, Ice, Dragon", "Poison, Sleep, Paralysis, Stun, Blast", "Fire", "Face, Feet, Tail(Severable)",
                "Anjanath Pelt, Anjanath Scale, Anjanath Fang, Anjanath Nosebone, Anjanath Tail, Monster Bone L, Flame Sac",
                "Anjanath Pelt +, Anjanath Scale +, Anjanath Fang +, Anjanath Nosebone+, Anjanath Gem, Monster Keenbone, Inferno Sac, Anjanath Plate"));
                monsters.Add(new Monster("Xeno'Jiiva", "Elder Dragon", "Elder's Recess", "Fire, Water, Ice, Dragon, Thunder",
                "Poison, Blast, Paralysis, Stun", "Sleep", "Head, Forelegs, Wings, Tail(Severable)", "None",
                "Xeno'jiiva Shell, Xeno'jiiva Soulscale, Xeno'jiiva Claw, Xeno'jiiva Horn, Xeno'jiiva Wing, " +
                "Xeno'jiiva Tail, Xeno'jiiva Gem, Xeno'jiiva Veil, Elder Dragon Bone, Elder Dragon Blood"));
                monsters.Add(new Monster("Zorah Magdaros", "Elder Dragon", "The Great Ravine, Everstream",
                "Dragon, Water, Ice, Thunder", "None", "Fire", "Head, Chest, Magmacore",
                "Zorah Magdaros Heat Scale, Zorah Magdaros Ridge, Zorah Magdaros Pleura, " +
                "Zorah Magdaros Magma, Zorah Magdaros Carapace, Zorah Magdaros Gem, Dragonite Ore", "None"));

                return Monsters;
            }
        }

        //Variable Declares for program use
        public string MonsterName { get; set; }
        public string MonsterSpecies { get; set; }
        public string MonsterLocation { get; set; }
        public string MonsterElementalWeakness { get; set; }
        public string MonsterAilmentWeakness { get; set; }
        public string MonsterResistances { get; set; }
        public string MonsterBreakSever { get; set; }
        public string MonsterRewardsLow { get; set; }
        public string MonsterRewardsHigh { get; set; }
        



        //Monster Arrays coincides for choices
        //string[] anjanath = new string[] { };

        //string[] xenoJiiva = new string[] { };

        //string[] zorahMagdaros = new string[] { };


    }
}
