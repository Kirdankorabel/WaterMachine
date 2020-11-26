using System;
using System.Collections.Generic;
using System.Text;

namespace WaterMachine.Model
    {
    public class Wanknote
    {
        public int Denomination { get; set; }
        public int countWanknotes { get; set; }


        public Wanknote (int denomination)
        {
            Denomination = denomination;
        }



    }
}
