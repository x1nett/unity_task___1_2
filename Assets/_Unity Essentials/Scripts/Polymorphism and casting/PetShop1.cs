using UnityEngine;
public class PetShop1 : MonoBehaviour
{
   [SerializeReference]
   public Mammal mammal = new Cat();
}
public class Animal3
{}

public class Mammal3 : Animal
{}
public class Cat3 : Mammal
{}