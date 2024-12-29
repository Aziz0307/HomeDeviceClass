namespace HomeDeviceDZ
{
    public class AirConditioner:HomeDevice
    {

        public AirConditioner(string name, int energy) 
        {
            GetDeviceName = name;
            GetEnergyConsumption = energy;
        }
    }
}