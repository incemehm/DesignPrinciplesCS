namespace InterfaceSegregationPrincipleIncorrect
{
    class Dog : IAnimal
    {
        public void Fly()
        {
            throw new System.NotImplementedException();
            //Dogs cannot fly
        }

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
