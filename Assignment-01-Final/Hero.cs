using System;

namespace Assignment_01_Final
{
    public class Hero
    {

     // CLASS PROPERTIES------------------------------------------------------

        //Public class properties
        public string name;

        //Private class properties
        private int strength;
        private int speed;
        private int health;

        // creating an object for the random class.
        Random rndNum = new Random();

     // CREATING A CONSTRUCTOR for the Hero Class that accepts name of the hero in the game 
        public Hero(string name)
        {
            this.name = name;
            generateAbilities();
        }
    
     //  METHODS  
        // This method generates strength, speed and health for the hero
        private void generateAbilities()
        {
            this.strength = rndNum.Next(1, 101);
            this.speed = rndNum.Next(1, 101);
            this.health = rndNum.Next(1, 101);

        }

        // This method prints the damage intensity made by the hero if the hit was made (means if the return value of the hitAttempt() is true)
        public void fight()
        {
            bool trueOrFalse;
            int damage;

            trueOrFalse = hitAttempt();

            if (trueOrFalse == true)
            {
                damage = hitDamage();
                Console.WriteLine("\nYeeha! Yeeeeha Yeeeeeha!!!.. this time our hero {0} hit the head off the villan!!!>. \nThe damage is:{1}\n", this.name, damage);

            }
            else
                Console.WriteLine("\nOh ooo... Our hero {0} missed the hit this time..\nWe should make him try again. \n", this.name);

        }

        //This method evaluates whether a hit was made or not.
        private bool hitAttempt()
        {

            int hitAttempt = rndNum.Next(1, 101);

            if (hitAttempt <= 20)
                return true;
            else
                return false;
        }

        //This method calculates the damage made by a hit (if the hit is made)
        private int hitDamage()
        {
            int damage = (this.strength * rndNum.Next(1, 7));
            return damage;
        }

        //This method outputs the name of the hero and his abilities
        public void show()
        {
            Console.WriteLine("{0}'s abilities are:\n\nStrength={1}\nSpeed={2}\nHealth={3}", this.name, this.strength, this.speed, this.health);
            Console.ReadKey();
        }

    }
}

