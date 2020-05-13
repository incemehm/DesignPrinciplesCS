namespace InterfaceSegregationPrincipleIncorrect
{
    class Fish : IAnimal
    {
        public void Fly()
        {
            throw new System.NotImplementedException();
            //Fish cannot fly
        }

        public void IsPet()
        {
            System.Console.WriteLine("Fish is pet...");
        }

        public void Swim()
        {
            System.Console.WriteLine("Fish's swimming...");
        }

        public void Walk()
        {
            throw new System.NotImplementedException();
            //Fish cannot walk
        }
    }
}
