namespace InterfaceSegregationPrincipleIncorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Fish fish = new Fish();
            Bird bird = new Bird();

            dog.IsPet();
            dog.Fly();   // It's defined for dog incorrectly. So you can call Fly method for dog and you get a NotImplementedException.
            dog.Swim();
            dog.Walk();

            fish.IsPet();
            fish.Fly();  // throw new NotImplementedException();
            fish.Swim();
            fish.Walk(); // throw new NotImplementedException();

            bird.IsPet();
            bird.Fly();
            bird.Swim(); // throw new NotImplementedException();
            bird.Walk();
        }
    }
}
