using UnityEngine;
using System.Collections;

public class SomeClase
{
    //Here is a generic method. Notice the generic
    //type 'T'. This 'T' will be replaced at runtime
    //with an actual type. 
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}