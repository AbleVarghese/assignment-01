using System;

namespace Assignment_01_Final
{
	class Program
	{
		static void Main(string[] args)
		{
			// Here an object is created for the Class called Hero, and the Object is named as 
			Hero StrongHeros = new Hero("Able");

			// Here the fight() method in class Hero is called for displaying the fight result.
			StrongHeros.fight();

			//Here the show() method in class Hero is called for displaying the name and status of this Hero
			StrongHeros.show();

			Console.ReadKey();


		}
	}
}
