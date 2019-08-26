using System;

namespace SniperElite
{
    public class ArmoredEnemy : Enemies
    {

        private int Armor = 100;
        private Boolean hasArmor;


        public Boolean getHasArmor()
        {
            return hasArmor;
        }

        public void setHasArmor(Boolean has)
        {
            hasArmor = has;
        }




    }
}