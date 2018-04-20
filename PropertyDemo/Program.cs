using System;

namespace PropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Player player = new Player(500);
            Console.WriteLine("Intial Health: " + player.Health);

            do
            {
                player.Hit();
            } while (player.IsAlive);
        }

        class Player
        {
            //In C# 6, get; only properties are only settable from the constructor. From everywhere else, it is read-only.
            //A property with a private set; can be set from everywhere inside that class.
            public int Health { get; private set; } //= 5000;   //property initializer
            public bool IsAlive
            {
                get
                {
                    if (Health > 0)
                    {
                        Console.WriteLine("Player is alive :)");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Player is dead! :(");
                        return false;
                    }
                }
            }

            public Player(int health)
            {
                Health = health;
            }

            public void Hit()
            {
                Random r = new Random();
                int healthAffectedByHit = r.Next(5, 20);
                Health -= healthAffectedByHit;
                Console.WriteLine("Player's health: " + Health + ", and player's hit! Health -" + healthAffectedByHit);   //if we omit private set in Health, we won't be able to set it here
            }
        }
    }
}
