using System;
using System.Collections;

namespace BitArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize BitArray with index
            BitArray enemyGrid = new BitArray(3);
            enemyGrid[0] = false;
            enemyGrid[1] = true;
            enemyGrid.Set(2, false);

            foreach (var enemy in enemyGrid)
            {
                Console.WriteLine(enemy);
            }

            //Initialize BitArray with a boolean array
            BitArray enemyGrid2 = new BitArray(new bool[] { true, false, true });

            foreach (var enemy in enemyGrid2)
            {
                Console.WriteLine(enemy);
            }
        }
    }
}
