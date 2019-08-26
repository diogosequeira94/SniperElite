using System;

namespace SniperElite
{
    public class Katana
    {
        private int hitDamage;
        
        public Katana(int hitDamage)
        {
            this.hitDamage = hitDamage;
        }
        
        public void attack(Enemies enemies)
        {
            Random random = new Random();
            int katanaStrike = random.Next(1, 30);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Guardian used Sword Strike with a power of: " + katanaStrike);
            Console.ResetColor(); 

            if (!enemies.isItDead())
            {
                if (katanaStrike < 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Crap! The shot has missed!");
                    Console.ResetColor();
                }
                else if (katanaStrike > 5)
                {
                    if (enemies.getHp() > 0)

                    {
                        enemies.setHp(enemies.getHp() - katanaStrike);
                        Console.WriteLine("My current hp is: " + enemies.getHp());
                    }
                    else if (enemies.getHp() - katanaStrike < 0 || enemies.getHp() < 0)
                    {
                        enemies.setIsDead(true);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("*** ENEMY IS DEAD ***");
                        Console.ResetColor();
                        
                    }
                }
            }
        }
    }
}