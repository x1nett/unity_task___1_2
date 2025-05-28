public class RescueShelter2
{
    Mammal1[] mammals;

    public RescueShelter2()
    {
        mammals = new Mammal1[2];
        mammals[0] = new Cat1();
        mammals[1] = new Dog1();

        // Safe casting and calling subclass methods
        Cat1 cat = mammals[0] as Cat1;
        if (cat != null)
        {
            cat.Meow();
        }

        Dog1 dog = mammals[1] as Dog1;
        if (dog != null)
        {
            dog.Woof();
        }
    }
}
