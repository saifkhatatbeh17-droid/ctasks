using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

using System;
using System.Collections.Generic;

namespace day6
{

    public interface ICollectible
    {
        void Collect();
    }

    public abstract class GameCharacter
    {
        private string _name;
        private int _health;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                    _health = 0;
                else if (value > 100)
                    _health = 100;
                else
                    _health = value;
            }
        }

        public GameCharacter(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} takes {amount} damage.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }

        public void Heal()
        {
            Health += 10;
            Console.WriteLine($"{Name} heals 10 points.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }

        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} heals {amount} points.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }
    }

    public class Warrior : GameCharacter
    {
        public Warrior(string name, int health) : base(name, health) { }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!");
        }

        public override void TakeDamage(int amount)
        {
            int reducedDamage = amount - 2;
            if (reducedDamage < 0) reducedDamage = 0;

            Health -= reducedDamage;
            Console.WriteLine($"{Name} takes {reducedDamage} damage.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }
    }

    public class Wizard : GameCharacter
    {
        public Wizard(string name, int health) : base(name, health) { }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Wizard uses magic!");
        }

        public override void TakeDamage(int amount)
        {
            base.TakeDamage(amount);
        }
    }

    public class HealthPotion : ICollectible
    {
        public string PotionName { get; set; }

        public HealthPotion(string potionName)
        {
            PotionName = potionName;
        }

        public void Collect()
        {
            Console.WriteLine($"{PotionName} collected!");
        }

        public void Use(GameCharacter character, string amountText)
        {
            try
            {
                int amount = Convert.ToInt32(amountText);
                character.Heal(amount);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ADVENTURE GAME =====");

            Warrior warrior = new Warrior("Alex", 80);
            Wizard wizard = new Wizard("Luna", 70);

            List<GameCharacter> characters = new List<GameCharacter> { warrior, wizard };
            HealthPotion potion = new HealthPotion("Health Potion");

            foreach (GameCharacter character in characters)
            {
                Console.WriteLine($"{character.GetType().Name} {character.Name} enters the game!");
                character.UseSpecialAbility();
                character.TakeDamage(10);

                if (character is Warrior)
                {
                    character.Heal();
                    character.Heal(15);
                }
                else if (character is Wizard)
                {
                    potion.Collect();
                    potion.Use(character, "15");
                    potion.Use(character, "abc");
                }
            }
        }
    }
}
