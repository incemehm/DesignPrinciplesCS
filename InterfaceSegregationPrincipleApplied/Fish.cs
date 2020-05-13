namespace InterfaceSegregationPrincipleApplied
{
    class Fish : IAnimal, ISwimmable
    {
        public void IsPet()
        {
            System.Console.WriteLine("Fish is pet...");
        }

        public void Swim()
        {
            System.Console.WriteLine("Fish's swimming...");
        }       
    }
}
