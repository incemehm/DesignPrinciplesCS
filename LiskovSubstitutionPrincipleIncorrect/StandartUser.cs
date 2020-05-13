namespace LiskovSubstitutionPrincipleIncorrect
{
    class StandartUser : IUser
    {
        public void Read()
        {
            System.Console.WriteLine("StandartUser reads");
        }

        public void Write()
        {
            throw new System.NotImplementedException();
        }
    }
}
