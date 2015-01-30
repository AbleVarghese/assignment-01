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
    


}
