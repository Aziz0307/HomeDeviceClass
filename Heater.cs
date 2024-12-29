namespace HomeDeviceDZ
{
    public class Heater:HomeDevice
    {
            public Heater(string name, int energy) 
            {
                GetDeviceName = name;
                GetEnergyConsumption = energy;
            }
    }
}