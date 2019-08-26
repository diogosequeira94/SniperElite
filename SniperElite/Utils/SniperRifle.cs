using System;

namespace SniperElite
{
    public class SniperRifle
    {
        private int bulletDamage;

        public SniperRifle(int bulletDamage)
        {
            this.bulletDamage = bulletDamage;
        }
        
        public void shootEnemy(Enemies enemies)
        {
            Random random = new Random();
            int bulletDamage = random.Next(1, 10);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A bullet was fired with the power of: " + bulletDamage);
            Console.ResetColor(); 

            if (!enemies.isItDead())
            {
                if (bulletDamage < 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Crap! The shot has missed!");
                    Console.ResetColor();
                }
                else if (bulletDamage > 5)
                {
                    if (enemies.getHp() > 0)

                    {
                        enemies.setHp(enemies.getHp() - bulletDamage);
                        Console.WriteLine("My current hp is: " + enemies.getHp());
                        enemies.warCry();
                    }
                    else if (enemies.getHp() - bulletDamage < 0 || enemies.getHp() < 0)
                    {
                        enemies.setIsDead(true);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("*** ENEMY IS DEAD ***");
                        Console.ResetColor();
                        {
                            enemies.warCry();
                        }
                    }
                }
            }
        }
    }
}