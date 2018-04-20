using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RollDiceGame();
            PlayHitGame();
        }

        private static void PlayHitGame()
        {
            Console.WriteLine("Hello World!");
            Player player = new Player(500);
            Console.WriteLine("Intial Health: " + player.Health);

            do
            {
                player.Hit();
            } while (player.IsAlive);
        }

        private static void RollDiceGame()
        {
            var names = new string[] { "Laurance", "Lisa", "Benjamin", "Shawn" };

            var random = new Random();

            Console.WriteLine("Dice Rolling Begin...\n");

            var candidates = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                candidates.Add(names[random.Next(names.Length)]);
            }

            for (int i = 0; i < candidates.Count; i++)
            {
                Console.WriteLine("Dice Rolling #" + (i + 1));
                Console.WriteLine($"The driver candidate picked randomly is: {candidates[i]}");
            }

            var driver = candidates.GroupBy(c => c).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();

            Console.WriteLine($"\nThe driver most frquently picked is: {driver}");

            Console.WriteLine($"Congratulations! {driver}");
        }

        class Player
        {
            public int Health { get; private set; }
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
                int healthChangeByHit = r.Next(5, 20);
                Health -= healthChangeByHit;
                Console.WriteLine("Player's health: " + Health + ", and player's hit! Health -" + healthChangeByHit);
            }
        }
    }
}
