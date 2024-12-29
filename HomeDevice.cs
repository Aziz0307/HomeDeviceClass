using System;

namespace HomeDeviceDZ
{
    public class HomeDevice
    {
        private string DeviceName;
        protected int EnergyConsumption;
        private bool IsOn;

        public string GetDeviceName
        {
            get { return DeviceName; }
            set { DeviceName = value; }
        }

        public int GetEnergyConsumption
        {
            get { return EnergyConsumption; }
            set { EnergyConsumption = value; }
        }

        public bool GetIsOn
        {
            get { return IsOn; }
            set { IsOn = value; }
        }

        public void TurnOn()
        {
            GetIsOn = true;
            Console.WriteLine($"The {GetDeviceName} is on.");
        }

        public void TurnOff()
        {
            GetIsOn = false;
            Console.WriteLine($"The {GetDeviceName} is off.");
        }

        public void SetEnergyConsumption(int energyConsumption)
        {
            EnergyConsumption = energyConsumption;
            Console.WriteLine($"Energy consumption of device is equal to {EnergyConsumption}.");
        }
    }
}