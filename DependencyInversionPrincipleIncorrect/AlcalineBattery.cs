namespace DependencyInversionPrincipleIncorrect
{
    class AlcalineBattery
    {
        int level { get; set; } = 100;

        public void Discharge()
        {
            if (this.level > 0)
                this.level -= 1;
        }
    }
}
