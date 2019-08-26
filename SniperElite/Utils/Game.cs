using System;
using System.Collections;
using System.Collections.Generic;

namespace SniperElite
{
    public class Game
    {

        private int shotsFired;
        private int sliceAttempt;

        public void getBanner()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------\n");
            Console.WriteLine("*************** Welcome to Sniper Elite Game ****************\n");
            Console.WriteLine("--------------------------------------------------------------\n");
            Console.ResetColor();


        }


        public void startGame(int people)
        {

            EnemieFactory enemieFactory = new EnemieFactory();

            List<Enemies> myArray = enemieFactory.buildEmpire(people);

            SniperRifle sniperRifle = new SniperRifle(10);
            
            Katana katana = new Katana(20);
            

            
            getBanner();
            
            while (!enemieFactory.allDead())
            {


                for (int i = 0; i < myArray.Count; i++)
                {
                    
                    Random randomWeapon = new Random();
                    int randomChoice = randomWeapon.Next(1 ,10);

                    if (!myArray[i].isItDead())
                    {
                        if (myArray[i].GetType() == typeof(BadGuy))
                        {
                            if (randomChoice < 6)
                            {
                                sniperRifle.shootEnemy(myArray[i]);
                                shotsFired++;

                            }
                            else
                            {
                                katana.attack(myArray[i]);
                                sliceAttempt++;
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            myArray[i].warCry();
                            Console.ResetColor();

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Don't shoot! I'm a tree :(");
                            Console.ResetColor();
                        }


                    }

                }
                
            }
            
            Console.WriteLine("Game Won!");

            enemieFactory.showStatistics(sliceAttempt, shotsFired);


        }



       
    }
}