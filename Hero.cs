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

    public void Hero(string name)
    {
        string name;
        this.name = name;
        generateAbilities();
    }

    private void generateAbilities()
    {
        Random rndNum = new Random();
        int strength = rndNum.Next(1, 100);
        int speed = rndNum.Next(1, 100);
        int health = rndNum.Next(1, 100);

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
    rndNum;
    Random rndNum = new Random();
    int hitAttempt = rndNum.Next(1, 100);

    if (hitAttempt <= 20)

        return true;
    else
        return false;
}




}

