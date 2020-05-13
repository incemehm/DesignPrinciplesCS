namespace InterfaceSegregationPrincipleIncorrect
{
    class Bird : IAnimal
    {
        public void Fly()
        {
            System.Console.WriteLine("Bird's flying...");
        }

        public void IsPet()
        {
            System.Console.WriteLine("Bird is pet...");
        }

        public void Swim()
        {
            throw new System.NotImplementedException();
            //Birds cannot swim
        }

        public void Walk()
        {
            System.Console.WriteLine("Bird's walking...");
        }
    }
}
