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
        chicken.Init("Chicky");
        animals.Add(chicken);
        //---------- Add Chicken ----------//

        //---------- Add Cow ----------//
        cow.Init("Milky");
        animals.Add(cow);
        //---------- Add Cow ----------//

        //---------- Add Pig ----------//
        pig.Init("John Pork");
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

        Debug.Log("");
        chicken.Feed(10);
        chicken.Feed(FoodType.Corn, 20);
        chicken.Produce();
        chicken.Feed(FoodType.RottenFood, 30);
        chicken.Produce();
        chicken.Feed(FoodType.RottenFood, 30);
        chicken.Produce();
        chicken.GetStatus();

        Debug.Log("");
        cow.Feed(10);
        cow.Feed(FoodType.Hey, 20);
        cow.Produce();
        cow.Feed(FoodType.Hey, 30);
        cow.Produce();
        cow.Feed(FoodType.Hey, 30);
        cow.Produce();
        chicken.GetStatus();

        Debug.Log("");
        pig.Feed(50);
        pig.Produce();
        pig.GetStatus();
    }
}