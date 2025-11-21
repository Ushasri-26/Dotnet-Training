using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment1
{
    public class GameCharacterPrototype
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public List<string> Skills { get; set; }
        public GameCharacterPrototype Clone()
        {
            return new GameCharacterPrototype
            {
                Health = this.Health,
                Attack = this.Attack,
                Defense = this.Defense,
                Skills = new List<string>(this.Skills)  // deep copy
            };
        }
        public void Display()
        {
            Console.WriteLine($"Health: {Health}, Attack: {Attack}, Defense: {Defense}");
            Console.WriteLine("Skills: " + string.Join(", ", Skills));
            Console.WriteLine("-----------------------------------");
        }
    }
    public static class CharacterPrototypes
    {
        public static GameCharacterPrototype WarriorPrototype = new GameCharacterPrototype
        {
            Health = 150,
            Attack = 40,
            Defense = 30,
            Skills = new List<string> { "Slash", "Shield Block", "Battle Cry" }
        };
    }
}
