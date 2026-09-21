using assignment_1;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;


namespace assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Hero myHero1 = new Hero("Jhon", "Human", "Warrior", 1);
            Hero myhero2 = new Hero("Luna", "Elf", "Mage", 2);
            Hero myhero3 = new Hero("Gimli", "Dwarf", "Rogue", 3);
            Hero myhero4 = new Hero("alakaraz", "Demon", "doom mage", 100);


            List<Hero> team = new List<Hero> { myHero1, myhero2, myhero3, myhero4 };


            Party myparty1 = new Party(team);


            myparty1.Displayparty();
            myparty1.Calculatepartylevel();

        }


    }

    class Hero
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Characterclass { get; set; }
        public int Level { get; set; }

        public Hero(string name, string race, string characterclass, int level)
        {
            Name = name;
            Race = race;
            Characterclass = characterclass;
            Level = level;
        }

        public void Displaycharactersheet()
        {
            Console.WriteLine($"Name: {Name}, - Race: {Race}, - Class: {Characterclass}, - Level: {Level}");
        }


    }

    class Party
    {

        private readonly List<Hero> team;
        public Party(List<Hero> team)
        {
            this.team = team ?? new List<Hero>();
        }

        public void Displayparty()
        {
            foreach (Hero hero in team)
            {
                hero.Displaycharactersheet();
            }
        }
        public void Calculatepartylevel()
        {
            List<int> partyLevels = new List<int>();

            foreach (Hero hero in team)
            {
                partyLevels.Add(hero.Level);
            }

            if (partyLevels.Count == 0)
            {
                Console.WriteLine("Average party level: 0 (no members)");
                return;
            }

            int totallevel = partyLevels.Sum();

            int averagelevel = totallevel / partyLevels.Count;
            Console.WriteLine(value: $"Average party level: {averagelevel}");
        }

    }


}
