namespace LiskovSubstitutionPrincipleApplied
{
    class AdminUser : IWriteUser, IReadUser
    {
        public void Read()
        {
            System.Console.WriteLine("AdminUser reads");
        }

        public void Write()
        {
            System.Console.WriteLine("AdminUser writes");
        }
    }
}
