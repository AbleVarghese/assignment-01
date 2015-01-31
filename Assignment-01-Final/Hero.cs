using System;

namespace Assignment_01_Final
{
    public class Hero
    {

        // Class Properties------------------------------------------------------

        //Public class properties
        public string name;

        //Private class properties
        private int strength;
        private int speed;
        private int health;

        // creating an object for the random class.

        Random rndNum = new Random();

        public Hero(string name)
        {
            this.name = name;
            generateAbilities();
        }

        private void generateAbilities()
        {
            this.strength = rndNum.Next(1, 101);
            this.speed = rndNum.Next(1, 101);
            this.health = rndNum.Next(1, 101);

        }

        public void fight()
        {
            bool trueOrFalse;
            int damage;

            trueOrFalse = hitAttempt();

            if (trueOrFalse == true)
            {
                damage = hitDamage();
                Console.WriteLine("Damage is:{0}", damage);

            }
            else 
            Console.WriteLine("The hero doesn't make a hit");

        }

        private bool hitAttempt()
        {

            int hitAttempt = rndNum.Next(1, 101);

            if (hitAttempt <= 20)
                return true;
            else
                return false;
        }

        private int hitDamage()
        {
            int damage = (this.strength * rndNum.Next(1, 7));
            return damage;
        }

        public void show()
        {
            Console.WriteLine("Hero's ability Scores\n\nStrength={0}\nSpeed={1}\nHealth={2}", this.strength, this.speed, this.health);
            Console.ReadKey();
        }

    }
}

