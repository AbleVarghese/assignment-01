using System;

public class Hero
{

    // Class Properties------------------------------------------------------

    //Public class properties
    public string name;

    //Private class properties
    private int strength;
    private int speed;
    private int health;


    // Methods--------------------------------------------------------

    //Public class methods
    public void fight();
    public void Show();

    //Private class methods
    private void generateAbilities();
    private bool hitAttempt();
    private int hitDamage();
    
    // creating an object for the random class.

    Random rndNum = new Random();

    public void Hero(string name)
    {
        string name;
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
    damage = (this.strength * rndNum.Next(1, 7));
    return damage; 
}





}

