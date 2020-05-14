using System.Collections.Generic;

namespace LiskovSubstitutionPrincipleIncorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IUser> users = new List<IUser>
                          {
                             new AdminUser(),
                             new StandartUser()
                          };

            Query(users);
            Operate(users);
        }

        static void Query(List<IUser> users)
        {
            users.ForEach(u =>
            {
                u.Read();
            });
        }

        static void Operate(List<IUser> users)
        {
            /*
                users.ForEach(u =>
                {
                    u.Write(); // when u is StandartUser, it throws NotImplementedException() 
                });
            */


            users.ForEach(u =>
            {
                try
                {
                    u.Write();
                }
                catch (System.Exception)
                {
                }
            });
            // Controlling with Try-catch block is the first solution that comes to mind but wrong

            users.ForEach(u =>
            {
                if (u is AdminUser)
                    u.Write();
            });
            // Type check is the second solution that comes to mind but wrong too.

        }
    }
}
