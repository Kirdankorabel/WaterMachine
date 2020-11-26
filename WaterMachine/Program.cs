using System;
using System.Collections.Generic;
using WaterMachine.Model;

namespace WaterMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            WaterMach waterMachine = new WaterMach(100, 3, 4, 3);
            Wanknote wanknote1 = new Wanknote(10);
            Wanknote wanknote2 = new Wanknote(10);
            Wanknote wanknote3 = new Wanknote(10);
            Wanknote wanknote4 = new Wanknote(10);
            Wanknote wanknote5 = new Wanknote(10);

            Console.WriteLine(waterMachine.FinishDate);

            waterMachine.RefuelingVolume();

            waterMachine.GetMoney(wanknote1);
            waterMachine.GetMoney(wanknote2);
            waterMachine.GetMoney(wanknote3);
            waterMachine.GetMoney(wanknote4);
            waterMachine.GetMoney(wanknote5);

            waterMachine.PourWater();
            Console.WriteLine($"{waterMachine.MoneyNow} - фантиков внесено");
            Console.WriteLine($"{waterMachine.BoughtWater} - воды куплено");
            Console.WriteLine($"{waterMachine.WanknotesNow} - купюр в приемнике");
            waterMachine.Start();
            Console.Read();
            waterMachine.Pause();

            Console.WriteLine($"{waterMachine.MoneyNow} - фантиков осталось");
            Console.WriteLine($"{waterMachine.BoughtWater} - воды осталось");
            Console.WriteLine($"{waterMachine.WanknotesNow} - купюр в приемнике");


            //Console.WriteLine("Что вы хотите сделать?");
            //Console.WriteLine("E - Ввести сумму денег");
            //Console.WriteLine("А - Набирать воду");
            //Console.WriteLine("Q - Остановить выливание воды");
            //Console.WriteLine("W - завершить работу");

            //var key = Console.ReadKey();
            //Console.Read();

            //for (; ; )
            //{
            //    switch (key.Key)
            //    {
            //        case ConsoleKey.E:
            //            //Console.WriteLine("Введите сумму");
            //            //var v = Console.ReadLine();
            //            //int value = Convert.ToInt32(v);
            //            Wanknote wanknote1 = new Wanknote(10);
            //            waterMachine.GetMoney(wanknote1);
            //            Console.Read();
            //            break;

            //        case ConsoleKey.A:
            //            waterMachine.Start();
            //            Console.Read();
            //            break;

            //        case ConsoleKey.Q:
            //            waterMachine.Pause();
            //            Console.Read();
            //            break;

            //        case ConsoleKey.W:
            //            Console.WriteLine(waterMachine.MoneyNow);
            //            Console.WriteLine(waterMachine.VolumeNow);
            //            Console.WriteLine(waterMachine.WanknotesNow);
            //            Console.Read();
            //            break;
            //    }
            //}
        }
    }
}
