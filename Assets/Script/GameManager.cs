using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Chicken chicken;
    public Cow cow;
    public Pig pig;
    public List<Animal> animals = new List<Animal>();

    private void Start()
    {
        //---------- Add Chicken ----------//
        chicken.Init("Chick fil A", 10, 10);
        animals.Add(chicken);
        //---------- Add Chicken ----------//

        //---------- Add Cow ----------//
        cow.Init("Polsih Cow", 20, 20);
        animals.Add(cow);
        //---------- Add Cow ----------//

        //---------- Add Pig ----------//
        pig.Init("John Pork", 15, 5);
        animals.Add(pig);
        //---------- Add Pig ----------//

        Debug.Log(">---------- Welcome to Farm Sim ----------<");
        Debug.Log($">> There are {animals.Count} animals living in the Happy Farm <<");

        foreach (Animal animal in animals)
        {
            animal.GetStatus();
        }

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            animal.Feed(5);
        }

        foreach (Animal animal in animals)
        {
            Debug.Log("");
            if (animal is Chicken)
            {
                animal.Feed("Corn", 3);
                chicken.Sleep();
            }
            else if (animal is Cow)
            {
                animal.Feed("Hey", 5);
                cow.Moo();
            }
            else if (animal is Pig)
            {
                animal.Feed("Grain", 5);
                pig.MakeSound();
                animal.GetStatus();
            }
        }
    }
}