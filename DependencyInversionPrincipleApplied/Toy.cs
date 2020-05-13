namespace DependencyInversionPrincipleApplied
{
    class Toy
    {
        public void UseBattery(IBattery battery)
        {
            battery.Discharge();
        }
    }
}
