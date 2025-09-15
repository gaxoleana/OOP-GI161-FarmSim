using UnityEngine;

class Cow
{
    //Attributes
    private string name; //Field
    public string Name //Property
    {
        get { return name; } //Returns the value of the variable name.
        set //Assigns a value to the name variable & Everything we classified as attributes gotta do the same.
        {
            if (string.IsNullOrEmpty(value)) //Conditions
                name = "Mysterious Cow";
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

    private float milk;
    public float Milk
    {
        get { return milk; }
        set
        {
            if (value < 0)
                milk = 0;
            else if (value >= 100)
                milk = 99;
            else
                milk = value;
        }
    }

    public Cow(string newName, int newHunger, int newHappiness, int newMilk) //Method parameters
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
        Milk = newMilk;
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
        Debug.Log($"{Name} says Moo!");
    }

    public void Feed()
    {
        AdjustHunger(-15);
        AdjustHappiness(+15);
        Debug.Log($"{Name} eats Hay happily.");
        GetStatus();
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} -> Hunger: {Hunger} | Happiness: {Happiness} | Total Milk: {Milk}.");
    }

    public void Moo()
    {
        AdjustHappiness(+10);
        Debug.Log($"{Name} gives a loud MooMoo!");
        GetStatus();
    }
}