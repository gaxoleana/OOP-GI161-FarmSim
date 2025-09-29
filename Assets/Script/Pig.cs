using UnityEngine;

public class Pig : Animal
{
    //----------Attributes----------//
    private int porkBelly;
    public int PorkBelly
    {
        get { return porkBelly; }
        private set { porkBelly = Mathf.Clamp(value, 0, 100); }
    }

    //----------Methods----------//
    public override void Init(string newName)
    {
        base.Init(newName);
        PreferredFood = FoodType.Grain;
        PorkBelly = 0;
    }

    public override void MakeSound()
    {
        Debug.Log($"{Names} says Hog!");
    }

    public override string Produce()
    {
        int producePorkBelly = 0;

        if (Happiness > 70)
        {
            PorkBelly += 1;
        }

        PorkBelly += producePorkBelly;
        
        string Produce = $"{Names} produced {producePorkBelly} units of Pork Belly, Total Pork Belly: {PorkBelly} units.";
        Debug.Log(Produce);
        return Produce;
    }
}
