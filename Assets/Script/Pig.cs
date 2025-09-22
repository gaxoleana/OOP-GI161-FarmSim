using UnityEngine;

public class Pig : Animal
{
    //----------Methods----------//
    public void Init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
    }

    public override void MakeSound()
    {
        Debug.Log($"{Names} says Hog!");
    }
}
