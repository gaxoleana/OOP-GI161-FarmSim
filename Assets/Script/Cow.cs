using UnityEngine;

public class Cow : Animal
{
    //----------Attributes----------//
    private float milk;
    public float Milk
    {
        get { return milk; }
        private set { milk = Mathf.Clamp(value, 0, 100); }
    }

    //----------Methods----------//
    public override void Init(string newName)
    {
        base.Init(newName);
        PreferredFood = FoodType.Hey;
        Milk = 0;
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says Moo!");
    }

    public void Moo()
    {
        AdjustHappiness(+10);
        Debug.Log($"{Name} gives a loud MooMoo!");
        GetStatus();
    }

    public override string Produce()
    {
        float produceMilk = 0f; 

        if (Happiness > 70)
        {
            produceMilk += Happiness / 10.0f;
        }

        Milk += produceMilk;

        string Produce = $"{Name} produced {produceMilk} units of Milk, Total Milk: {Milk} units.";
        Debug.Log(Produce);
        return Produce;
    }
}