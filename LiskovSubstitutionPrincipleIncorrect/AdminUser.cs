namespace LiskovSubstitutionPrincipleIncorrect
{
    class AdminUser : IUser
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
