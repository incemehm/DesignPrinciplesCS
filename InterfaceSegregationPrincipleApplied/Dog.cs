namespace InterfaceSegregationPrincipleApplied
{
    class Dog : IAnimal, ISwimmable, IWalkable
    {
        public void IsPet()
        {
            System.Console.WriteLine("Dog is pet...");
        }

        public void Swim()
        {
            System.Console.WriteLine("Dog's swimming...");
        }

        public void Walk()
        {
            System.Console.WriteLine("Dog's walking...");
        }
    }
}
