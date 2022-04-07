using System;


/*
 
В классе :
-информация о названии аэропорта  // аэро
-стоимость билета(одинаковая)     // тикет - статическая фигня
-число мест в самолетах (общее)   // аэро

Методы:
-подсчет общей стоимости всех проданных билетов  // счетчик в тикет*статическую фигню стоимомти
-возможеость изменения стоимости билета  //сеттер для статической вигни ака стоимости

Общее:
- класс-контейнер + класс-лошок
- наличие полей, методов, свойств
- перегрузка методов
- применитьь к классу-контейнеру (аэропорт) Singlеton

*/






namespace Singletonskaya_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            Aero aeroport = Aero.create();
            while (true)
            { 
                switch (number)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Input name of the airport: ");
                        string name = Console.ReadLine();
                        aeroport.Rename(name);
                        Console.WriteLine("Input number of places in the airport: ");
                        int num = int.Parse(Console.ReadLine());
                        aeroport.Places();
                        Console.WriteLine("Input price of a ticket: ");
                        aeroport.ChangePrice();
                        Console.WriteLine("Input number of the ticket sold: ");
                        aeroport.SellNTickets();
                        number = 6;
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Price of a ticket:\t" + aeroport.Price());
                        Console.WriteLine("\ninput number to increase the price: ");
                        int a;
                        while (!int.TryParse(Console.ReadLine(), out a) ||
                a > int.MaxValue || a < 0) Console.WriteLine("Input Error! Try again:   ");
                        aeroport.MakeHigherPrice(a);
                        number = 6;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Price of a ticket:\t" + aeroport.Price());
                        Console.WriteLine("\ninput number to decrease the price: ");
                        int b;
                        while (!int.TryParse(Console.ReadLine(), out b) ||
               b > aeroport.Price() || b < 0) Console.WriteLine("Input Error! Try again:   ");
                        aeroport.MakeLoverPrice(b);
                        number = 6;
                        break;
                    case 5:
                        return;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Your data:" +
                                          "\n Name of the airport:" + aeroport.Name() +
                                          "\n Number of places in the airport:\t" + aeroport.Places() +
                                          "\n Price of a ticket:\t" + aeroport.Price() +
                                          "\n Number of sold tickets:\t" + aeroport.Sold() +
                                          "\n Whole valid for sold tickets:\t" + aeroport.CostOfSold());
                                          
                        Console.WriteLine("\n\n1 - Restart.\n2 -Increase tickets' price.\n3 - Decrease tickets' price.\n4 - Sell another ticket.\n5.Exit.\t");
                        while (!int.TryParse(Console.ReadLine(), out number) || number > 5 || number < 1) Console.WriteLine("Input error, try again:\t");
                        break;
                    case 4:
                        aeroport.SellTicket();
                        number = 6;
                        break;
                }






            }
        }
    }
}
