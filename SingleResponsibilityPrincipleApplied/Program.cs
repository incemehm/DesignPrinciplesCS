namespace SingleResponsibilityPrincipleApplied
{
    class Program
    {
        static void Main(string[] args)
        {
            BackendDeveloper backendDeveloper = new BackendDeveloper();
            backendDeveloper.CreateAPI();

            FrontendDeveloper frontendDeveloper = new FrontendDeveloper();
            frontendDeveloper.DesignPage();

            /* It fulfills Single Responsibility principle.
             * BackendDeveloper does his own job.
             * FrontendDeveloper does his own job.
             */
        }
    }
}
