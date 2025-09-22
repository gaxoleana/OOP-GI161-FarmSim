using UnityEngine;

public class Chicken : Animal
{
    //----------Attributes----------//
    private int egg;
    public int Egg
    {
        get { return egg; }
        private set
        {
            if (value < 0)
                egg = 0;
            else if (value >= 100)
                egg = 99;
            else
                egg = value;
        }
    }

    //----------Methods----------//
    public void Init(string newName, int newHunger, int newHappiness, int newEgg)
    {
        base.Init(newName, newHunger, newHappiness);
        Egg = newEgg;
    }

    public override void MakeSound()
    {
        Debug.Log($"{Names} says Cluck!");
    }

    public void Sleep()
    {
        AdjustHunger(+2);
        AdjustHappiness(+10);
        Debug.Log($"{Names} slept and feels a little hungry, but very happy!");
        GetStatus();
    }
}