using UnityEngine;
using System.Collections;

public class SomeOtherClass : MonoBehaviour 
{
    void Start () 
    {
        SomeClase myClass = new SomeClase();

        //In order to use this method you must
        //tell the method what type to replace
        //'T' with.
        myClass.GenericMethod<int>(5);
    }
}