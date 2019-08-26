using System;
using System.Collections;
using System.Collections.Generic;

namespace SniperElite
{
    public class EnemieFactory
    {
        List<Enemies> enemies = new List<Enemies>();
        private int numberOfTrees;
        private int numberOfBadGuys;

        public EnemieFactory()
        {
        }

        public List<Enemies> buildEmpire(int enemieNumber)
        {
            for (int i = 0; i < enemieNumber; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 10);

                if (randomNumber > 5)
                {
                    BadGuy badGuy = new BadGuy();
                    enemies.Add(badGuy);
                    numberOfBadGuys++;
                }
                else
                {
                    Tree tree = new Tree();
                    enemies.Add(tree);
                    numberOfTrees++;
                }
            }

            return enemies;
        }

        public Boolean allDead()
        {

            int counter = 0;
            
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].isItDead())
                {
                    counter++;
                }
            }

            if (counter == numberOfBadGuys)
            {
                return true;
            }

            return false;
        }

        public void showStatistics()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Statistics of the Game:\n");
            Console.WriteLine("Number of Trees: " + numberOfTrees);
            Console.WriteLine("Number of Bad Guys: " + numberOfBadGuys);
            Console.WriteLine("-------------------------------------");
            Console.ResetColor();
            
        }
    }
}