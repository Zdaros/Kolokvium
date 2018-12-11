using System;
namespace Kolokvium.Classes
{
    public class SamplingData : HumanSettlement
    {
        private string GeomorphicBinding;
        private string Date;
        private float Gasoline;
        private float CO2;
        private float CO;
        private float SO2;
        private float HCI;

        public int id;

        public string GetGeomorphicBinding() { return GeomorphicBinding; }
        public string GetDate() { return Date; }
        public float GetGasoline() { return Gasoline; }
        public float GetCO2() { return CO2; }
        public float GetCO() { return CO; }
        public float GetSO2() { return SO2; }
        public float GetHCI() { return HCI; }


        public void SetGeomorphicBinding(string GeomorphicBinding) { this.GeomorphicBinding = GeomorphicBinding; }
        public void SetDate(string Date) { this.Date = Date; }
        public void SetGasoline(float Gasoline) { this.Gasoline = Gasoline; }
        public void SetCO2(float CO2) { this.CO2 = CO2; }
        public void SetCO(float CO) { this.CO = CO; }
        public void SetSO2(float SO2) { this.SO2 = SO2; }
        public void SetHCI(float HCI) { this.HCI = HCI; }

        public SamplingData()
        {
        }
    }
}
