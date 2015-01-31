/* Assigment 01
 * Name: Able Varghese
 * Student No: 300 806 906
 * 
 * This program is a game where we have a hero who is set out to hit a villan. 20% of the time our hero will be successful and hits the villan, 
 * but rest of the time he'll miss it. Our program has the ability to evaluate the damage caused by a hit if our hero manage to hit the villan.
 * There are 4 properties and 6 methods implemented in the Hero class associated with this program.
 
 */


using System;

namespace Assignment_01_Final
{
	class Program
	{
		static void Main(string[] args)
        {
            string hero;

            Console.WriteLine("Please enter the name of the hero");
            hero=Console.ReadLine();
			// Here an object is created for the Class called Hero, and the Object is named as 
			Hero StrongHeros = new Hero(hero);

			// Here the fight() method in class Hero is called for displaying the fight result.
			StrongHeros.fight();

			//Here the show() method in class Hero is called for displaying the name and status of this Hero
			StrongHeros.show();

			Console.ReadKey();


		}
	}
}
