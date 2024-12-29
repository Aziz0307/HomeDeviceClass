using System;

namespace HomeDeviceDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            AirConditioner airConditioner = new AirConditioner("Samsung AC", 2000);
            Heater heater = new Heater("Electrolux Heater", 1500);
            airConditioner.TurnOn();
            airConditioner.SetEnergyConsumption(2500);
            airConditioner.TurnOff();
            heater.TurnOn();
            heater.SetEnergyConsumption(1500);
            heater.TurnOff();
        }
    }
}