using System.Collections.Generic;

namespace LiskovSubstitutionPrincipleApplied
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IReadUser> readUsers = new List<IReadUser>
                          {
                             new AdminUser(),
                             new StandartUser()
                          };


            List<IWriteUser> writeUsers = new List<IWriteUser>
                          {             
                             new AdminUser(),
                             new AdminUser()
                          };

            Query(readUsers);
            Operate(writeUsers);
        }

        static void Query(List<IReadUser> users)
        {
            users.ForEach(u =>
            {
                u.Read();
            });
        }

        static void Operate(List<IWriteUser> users)
        {
            users.ForEach(u =>
            {
                u.Write(); 
            });

            // Now we can use Write method without type checking.
            // It operates over class objects that implement IWriteUser interface.
        }
    }
}
