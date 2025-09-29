using UnityEngine;

public enum FoodType
{
    Corn,       //0
    Hey,        //1
    Grain,      //2
    RottenFood, //3
    AnimalFood  //4
}

public abstract class Animal : MonoBehaviour
{
    //----------Attributes----------//
    private string name;   //Field
    public string Name     //Property
    {
        get { return name; }   //Returns the value of the variable name.
        private set { name = string.IsNullOrEmpty(value) ? "Unknown Animal" : value; } //Assigns a value to the name variable & Everything we classified as attributes gotta do the same.
    }

    private int hunger;
    public int Hunger
    {
        get { return hunger; }
        private set { hunger = Mathf.Clamp(value, 0 ,100); }
    }

    private int happiness;
    public int Happiness
    {
        get { return happiness; }
        private set { happiness = Mathf.Clamp(value, 0 , 100); }
    }

    public FoodType PreferredFood { get; protected set; }

    //----------Methods----------//
    public virtual void Init(string newName) //Method parameters
    {
        Name = newName;
        Hunger = 50;
        Happiness = 50;
    }

    public void AdjustHunger(int hungerValue)
    {
        Hunger += hungerValue;
    }

    public void AdjustHappiness(int happinessValue)
    {
        Happiness += happinessValue;
    }

    public virtual void GetStatus()
    {
        Debug.Log($"{Name} -> Hunger: {Hunger} | Happiness: {Happiness} | Prefered Food: {PreferredFood}");
    }

    public virtual void Feed(int foodAmount)
    {
        AdjustHunger(-foodAmount);
        AdjustHappiness(+foodAmount / 2);
        Debug.Log($"{Name} was fed {foodAmount} of generic food. Current Happiness: {Happiness}");
    }

    public virtual void Feed(FoodType foodType, int foodAmount)
    {
        if (foodType == PreferredFood)
        {
            AdjustHunger(-foodAmount);
            AdjustHappiness(+15);
            Debug.Log($"{Name} was fed {foodAmount} units of preferred food : {PreferredFood}, Happiness increased 15 units, Current Happiness {Happiness}");
        }

        else if (foodType == FoodType.RottenFood)
        {
            AdjustHappiness(-20);
            Debug.Log($"{Name} was fed with rotten food : {FoodType.RottenFood}. Unhappy! Happiness decreased 20 units, Current Happiness {Happiness}");
        }

        else if (foodType == FoodType.AnimalFood)
        {
            Feed(foodAmount);
        }
    }

    public abstract void MakeSound();

    public abstract string Produce();
}
