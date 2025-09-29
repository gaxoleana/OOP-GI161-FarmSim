using UnityEngine;

public class Chicken : Animal
{
    //----------Attributes----------//
    private int egg;
    public int Egg
    {
        get { return egg; }
        private set { egg = Mathf.Clamp(value, 0, 100); }
    }

    //----------Methods----------//
    public override void Init(string newName)
    {
        base.Init(newName);
        PreferredFood = FoodType.Corn;
        Egg = 0;
    }

    public void Sleep()
    {
        AdjustHunger(+2);
        AdjustHappiness(+10);
        Debug.Log($"{Name} slept and feels a little hungry, but very happy!");
        GetStatus();
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says Cluck!");
    }

    public override string Produce()
    {
        int produceEgg = 0;

        if (Happiness >= 80)
        {
            produceEgg += 3;
        }
        else if (Happiness > 50)
        {
            produceEgg += 2;
        }
        else if (Happiness <= 50)
        {
            produceEgg += 0;
        }

        Egg += produceEgg;

        string Produce = $"{Name} produced {produceEgg} eggs, Total Eggs: {Egg} eggs";
        Debug.Log(Produce);
        return Produce;
    }
}