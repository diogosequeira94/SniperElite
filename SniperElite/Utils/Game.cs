using System;
using System.Collections;
using System.Collections.Generic;

namespace SniperElite
{
    public class Game
    {

        public void getBanner()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------\n");
            Console.WriteLine("*************** Welcome to Sniper Elite Game ***************\n");
            Console.WriteLine("--------------------------------------------------------------\n");
            Console.ResetColor();


        }


        public void startGame(int people)
        {

            EnemieFactory enemieFactory = new EnemieFactory();

            List<Enemies> myArray = enemieFactory.buildEmpire(people);

            SniperRifle sniperRifle = new SniperRifle(10);
            

            
            getBanner();
            
            while (!enemieFactory.allDead())
            {


                for (int i = 0; i < myArray.Count; i++)
                {

                    if (!myArray[i].isItDead())
                    {
                        if (myArray[i].GetType() == typeof(BadGuy))
                        {
                            sniperRifle.shootEnemy(myArray[i]);
                            myArray[i].warCry();

                        }
                        else
                        {
                            Console.WriteLine("Don't shoot! I'm a tree :(");
                        }


                    }

                }
                
            }
            
            enemieFactory.showStatistics();
            Console.WriteLine("Game Won!");


        }



       
    }
}