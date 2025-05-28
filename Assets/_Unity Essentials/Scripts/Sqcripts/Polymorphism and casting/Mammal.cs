public class Mammal1
{
    public void GrowFur()
    {
        UnityEngine.Debug.Log("Growing fur...");
    }
}

public class Cat1 : Mammal1
{
    public void Meow()
    {
        UnityEngine.Debug.Log("Meow!");
    }
}

public class Dog1 : Mammal1
{
    public void Woof()
    {
        UnityEngine.Debug.Log("Woof!");
    }
}

public class RescueShelter
{
    public Mammal1[] mammals1;

    public RescueShelter()
    {
        mammals1 = new Mammal1[2];
        mammals1[0] = new Cat1();   // ✅ Corrected
        mammals1[1] = new Dog1();   // ✅ Already good
    }
}
