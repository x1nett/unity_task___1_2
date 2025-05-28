public class RescueShelter1
{
    Mammal1[] mammals1;

    public RescueShelter1()
    {
        mammals1 = new Mammal1[2];
        mammals1[0] = new Cat1();
        mammals1[1] = new Dog1();

        if (mammals1[0] is Cat1)
        {
            Cat1 cat = mammals1[0] as Cat1;
            cat.Meow();
        }

        if (mammals1[1] is Dog1)
        {
            Dog1 dog = (Dog1)mammals1[1];
            dog.Woof();
        }
    }
}
