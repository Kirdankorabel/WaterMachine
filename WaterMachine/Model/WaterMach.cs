using System;
using System.Collections.Generic;
using System.Text;

namespace WaterMachine.Model
    {
    public class WaterMach
    {
        #region свойства
        public decimal VolumeMax { get; set; }
        public decimal VolumeNow { get; set; }
        public decimal WaterPrise { get; set; }
        public static int WanknotesMax { get; set; }
        public int WanknotesNow { get; set; }
        public static int CoinsMax { get; set; }
        public decimal MoneyNow { get; set; }
        public decimal BoughtWater { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        #endregion

        public WaterMach (decimal volumeMax, decimal waterPrise, int wanknotesMax, int coinsMax)
        {
            VolumeMax = volumeMax;
            WaterPrise = waterPrise;
            WanknotesMax = wanknotesMax;
            CoinsMax = coinsMax;
        }

        List<Wanknote> Wanknotes = new List<Wanknote>(WanknotesMax);
        private const double V = 0.3;
        public void CheсkVolume ()
        {
            decimal volume = VolumeNow;
            Console.WriteLine(volume);
        }
        public void RefuelingVolume()
        {
            VolumeNow = VolumeMax;
        }
        public (decimal, decimal, decimal, decimal) GetMoney(Wanknote wanknote)
        {
            int money = wanknote.Denomination;

            //WanknotesNow = Wanknotes.Count;
            decimal boughtWater = money / WaterPrise;
            if (WanknotesNow < WanknotesMax && boughtWater <= VolumeNow)
            {
                Console.WriteLine("Фентики успешно внесены");                
                VolumeNow -= boughtWater;
                MoneyNow += money;
                BoughtWater += boughtWater;
                WanknotesNow += 1;
                return (MoneyNow, VolumeNow, WanknotesNow, BoughtWater);
            }
            else
            {
                Console.WriteLine("Нуждается в обслуживании");
                return (MoneyNow, VolumeNow, WanknotesNow, BoughtWater);
            }
        }
        public void PourWater()
        {
            Console.WriteLine(BoughtWater);
        }
        public DateTime Start()
        {
            DateTime StartDate = DateTime.Now;
            if (StartDate > FinishDate)
            {
                decimal waterPerSecond = (decimal)V;
                int pouringTime = (int)(BoughtWater / waterPerSecond);
                FinishDate = StartDate.AddSeconds(pouringTime);
                return FinishDate;
            }
            else
            {
                return FinishDate;
            }
        }
        public (decimal, decimal) Pause()
        {
            DateTime dateNow = DateTime.Now;
            if (dateNow < FinishDate)
            {
                int stopTime = dateNow.Second + 60 * dateNow.Minute;
                int finishTime = FinishDate.Second + 60 * FinishDate.Minute;
                int second = finishTime - stopTime;
                BoughtWater = (decimal)(second * V);
                MoneyNow = BoughtWater * WaterPrise;
                return (BoughtWater, MoneyNow);
            }
            else
            {
                return (BoughtWater, MoneyNow);
            }
        }
        public bool CheckWaterMachine ()
        {
            DateTime DateNow = DateTime.Now;
            if(DateNow > FinishDate )
            {
                Console.WriteLine("Автомат выливает воду");
                return true;
            }
            else
            {
                Console.WriteLine("Автомат не льет воду");
                return false;
            }
        }

    }
}
