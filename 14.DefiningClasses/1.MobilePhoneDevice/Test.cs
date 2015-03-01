using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.MobilePhoneDevice
{
    class GSMTestClass
    {
        static void Main()
        {
            Battery bat = new Battery("bateria", BatteryType.LiIon, 6.3, 5.3);
            Display dis = new Display("10X20", 1000000);

            GSM phone = new GSM("Galaxy", "Samsung", "Gosho", 500.5M, bat, dis);

            phone.AddCall(new Call(new DateTime(2010, 2, 12, 13, 45, 10), "0888547586", 344));
            phone.AddCall(new Call(new DateTime(2010, 1, 10, 13, 45, 10), "0888547586", 44));
            phone.AddCall(new Call(new DateTime(2010, 10, 22, 3, 45, 10), "0878547586", 101));

            Console.WriteLine(phone.ToString());

            foreach (var item in phone.CallHistory)
            {
                Console.WriteLine(item.ToString());
            }

            decimal callsPrice = phone.CalculateCallPrice(0.37M);
            Console.WriteLine("Calls price: {0:0.00}", callsPrice);

            phone.CallHistory.OrderByDescending(x => x.DurationSeconds);
            phone.DeleteCall(0);

            decimal priceAfter = phone.CalculateCallPrice(0.37M);
            Console.WriteLine("{0:0.00}", priceAfter);

            Console.ReadKey();
        }
    }
}
