using UnityEngine;

class Chicken
{
    //Attributes
    private string name; //Field
    public string Name //Property
    {
        get { return name; } //Returns the value of the variable name.
        set //Assigns a value to the name variable & Everything we classified as attributes gotta do the same.
        {
            if (string.IsNullOrEmpty(value)) //Conditions
                name = "Mysterious Chicken";
            else
                name = value;
        }
    }

    private int hunger;
    public int Hunger
    {
        get { return hunger; }
        set
        {
            if (value < 0) //Avoid negative value.
                hunger = 0;
            else if (value > 50) //Value capacity cap.
                hunger = 50;
            else
                hunger = value;
        }
    }

    private int happiness;
    public int Happiness
    {
        get { return happiness; }
        set
        {
            if (value < 0)
                happiness = 0;
            else if (value > 50)
                happiness = 50;
            else
                happiness = value;
        }
    }

    private int egg;
    public int Egg
    {
        get { return egg; }
        set
        {
            if (value < 0)
                egg = 0;
            else if (value >= 100)
                egg = 99;
            else
                egg = value;
        }
    }

    //Method sections
    public Chicken(string newName, int newHunger, int newHappiness, int newEgg) //Method parameters
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
        Egg = newEgg;
    }

    public void AdjustHunger(int hungerValue)
    {
        Hunger += hungerValue;
    }

    public void AdjustHappiness(int happinessValue)
    {
        Happiness += happinessValue;
    }

    public void MakeSound()
    {
        Debug.Log($"{Name} says Cluck!");
    }

    public void Feed()
    {
        AdjustHunger(-5);
        AdjustHappiness(+5);
        Debug.Log($"{Name} eats Corn happily.");
        GetStatus();
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} -> Hunger: {Hunger} | Happiness: {Happiness} | Total Egg: {Egg}.");
    }

    public void Sleep()
    {
        AdjustHunger(+2);
        AdjustHappiness(+10);
        Debug.Log($"{Name} slept and feels a little hungry, but very happy!");
        GetStatus();
    }
}