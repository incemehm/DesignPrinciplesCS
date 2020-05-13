namespace LiskovSubstitutionPrincipleApplied
{
    class StandartUser : IReadUser
    {
        public void Read()
        {
            System.Console.WriteLine("StandartUser reads");
        }
    }
}
