namespace SingleResponsibilityPrincipleIncorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer();
            developer.CreateAPI();
            developer.DesignPage();

            /* It breaks Single Responsibility principle.
             * Developer has to do two unrelated jobs.
             */
        }
    }
}
