using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    //----------Attributes----------//
    private string names; //Field
    public string Names //Property
    {
        get { return names; }//Returns the value of the variable name.
        private set //Assigns a value to the name variable & Everything we classified as attributes gotta do the same.
        {
            if (string.IsNullOrEmpty(value))
                names = "Unknown Animal";
            else
                names = value;
        }
    }

    private int hunger;
    public int Hunger
    {
        get { return hunger; }
        private set
        {
            if (value < 0) //Avoid negative value.
                hunger = 0;
            else if (value > 100) //Value capacity cap.
                hunger = 100;
            else
                hunger = value;
        }
    }

    private int happiness;
    public int Happiness
    {
        get { return happiness; }
        private set
        {
            if (value < 0)
                happiness = 0;
            else if (value > 100)
                happiness = 100;
            else
                happiness = value;
        }
    }

    //----------Methods----------//
    public void Init(string newName, int newHunger, int newHappiness) //Method parameters
    {
        Names = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
    }

    public void AdjustHunger(int hungerValue)
    {
        Hunger += hungerValue;
    }

    public void AdjustHappiness(int happinessValue)
    {
        Happiness += happinessValue;
    }

    public virtual void MakeSound()
    {
        Debug.Log($"{Names} says something!");
    }

    public virtual void Feed(int foodAmount)
    {
        AdjustHunger(-foodAmount);
        AdjustHappiness(+foodAmount);
        Debug.Log($"{Names} was fed {foodAmount} units of food.");
    }
    public virtual void Feed(string foodName, int foodAmount)
    {
        AdjustHunger(-foodAmount);
        AdjustHappiness(+foodAmount);
        Debug.Log($"{Names} was fed {foodAmount} of {foodName}.");
    }

    public virtual void GetStatus()
    {
        Debug.Log($"{Names} -> Hunger: {Hunger} | Happiness: {Happiness}");
    }
}
