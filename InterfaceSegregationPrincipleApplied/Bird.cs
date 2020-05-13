namespace InterfaceSegregationPrincipleApplied
{
    class Bird : IAnimal, IFlyable, IWalkable
    {
        public void Fly()
        {
            System.Console.WriteLine("Bird's flying...");
        }

        public void IsPet()
        {
            System.Console.WriteLine("Bird is pet...");
        }
        
        public void Walk()
        {
            System.Console.WriteLine("Bird's walking...");
        }
    }
}
