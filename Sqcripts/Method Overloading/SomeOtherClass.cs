using UnityEngine;
using System.Collections;

public class SomeOtherClasse : MonoBehaviour 
{
    void Start () 
    {
        SomeClasse myClass = new SomeClasse();

        //The specific Add method called will depend on
        //the arguments passed in.
        myClass.Add (1, 2);
        myClass.Add ("Hello ", "World");
    }
}
