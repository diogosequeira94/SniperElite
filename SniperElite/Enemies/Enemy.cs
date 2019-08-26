using System;

namespace SniperElite
{
    public class Enemies
    {

        private int hp = 100;
        private Boolean isDead;

        public virtual void warCry()
        {
            Console.WriteLine("Shit I got hit!");
        }

        public int getHp()
        {
            return hp;
        }

        public void setHp(int hp)
        {
            this.hp = hp;
        }

        public Boolean isItDead()
        {
            return isDead;
        }

        public void setIsDead(Boolean isIt)
        {
            isDead = isIt;
        }

        public void myCurrentHp()
        {
            Console.WriteLine("My current hp is: " + hp);

        }
    }
}