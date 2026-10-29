using UnityEngine;
using HelloInvestigation;

public class HelloWorld : MonoBehaviour
{
    private void Start()
    {
        Greeting greeting = new Greeting();
        greeting.Name = "Duff";
        Debug.Log(greeting.BuildMessage());
    }
}