using UnityEngine;

public class GameManager : MonoBehaviour
{
    Chicken chicken = new Chicken("Dodo", 10, 10, 0);
    Cow cow = new Cow("Timothy", 15, 15, 0);

    void Start()
    {
        Debug.Log(">---------- Welcome to Farm Sim ----------<");
        Debug.Log($">> {chicken.Name} and {cow.Name} are living in the farm <<");

        chicken.GetStatus();

        chicken.MakeSound();

        chicken.Feed();

        chicken.Sleep();

        Debug.Log(">--------------------<");

        cow.GetStatus();

        cow.MakeSound();

        cow.Feed();

        cow.Moo();
    }
}