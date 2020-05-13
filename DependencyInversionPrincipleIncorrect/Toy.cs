namespace DependencyInversionPrincipleIncorrect
{
    class Toy
    {
        public void UseBattery(ZincCarbonBattery battery)
        {
            battery.Discharge();
        }
    }
}
