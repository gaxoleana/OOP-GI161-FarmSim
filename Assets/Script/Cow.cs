using UnityEngine;

public class Cow : Animal
{
    //----------Attributes----------//
    private float milk;
    public float Milk
    {
        get { return milk; }
        private set
        {
            if (value < 0)
                milk = 0;
            else if (value >= 100)
                milk = 99;
            else
                milk = value;
        }
    }

    //----------Methods----------//
    public void Init(string newName, int newHunger, int newHappiness, int newMilk)
    {
        base.Init(newName, newHunger, newHappiness);
        Milk = newMilk;
    }

    public override void MakeSound()
    {
        Debug.Log($"{Names} says Moo!");
    }

    public void Moo()
    {
        AdjustHappiness(+10);
        Debug.Log($"{Names} gives a loud MooMoo!");
        GetStatus();
    }
}