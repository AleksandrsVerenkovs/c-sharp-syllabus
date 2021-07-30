namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double Liters;
        public Car(double liters)
        {
            Liters = liters;
        }

        public double CalculateConsumption(int mileage, double liters)
        {
            return mileage / Liters - liters;
        }

        private double ConsumptionPer100Km()
        {
            return 100 / Liters;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            Liters += mileage / (mileage / liters);
        }
    }
}
