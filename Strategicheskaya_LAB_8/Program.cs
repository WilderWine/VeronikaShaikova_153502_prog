using System;

namespace Strategicheskaya_LAB_8
{
    class Program
    {

        public static void AddMain(ref Aeroport aeroport)
        {
            string answer = "HZ", destination = "XZ";
            int pr = 0;
            Console.WriteLine("Place of destination:\t");
            destination = Console.ReadLine();
            Console.WriteLine("Price (integer):\t");

            do
            {
                while (!int.TryParse(Console.ReadLine(), out pr)) ;
            } while (pr < 1);
            Console.WriteLine("Would you like to make a discount?\t\t");

            do
            {
                answer = Console.ReadLine();
            } while (answer != "yes" && answer != "no");

            switch (answer)
            {
                case "yes":
                    {
                        int dis;
                        Console.WriteLine("Discount, %:\t");
                        do
                        {
                            while (!int.TryParse(Console.ReadLine(), out dis)) ;
                        } while (dis < 1 || dis > 100);
                        Ticket first = new Ticket(destination, pr, dis);
                        aeroport.AddTarrif(first);
                        break;
                    }
                case "no":
                    {
                        Ticket first = new Ticket(destination, pr);
                        aeroport.AddTarrif(first);
                        break;
                    }
            }
        }

        static void Main(string[] args)
        {

            Aeroport aeroport = new Aeroport();

            Console.WriteLine("Now list of tickets is empty ─ add first one to start the work:\n");

            AddMain(ref aeroport);

            Console.Clear();

            bool rep = true;

            while (rep)
            {
               
                Console.WriteLine("Choose action:\n1.  Get info about tarrifs\n2.  Add new ticket\n3.  Exit\t");


                int action = 45;
                do
                {
                    while (!int.TryParse(Console.ReadLine(), out action)) ;
                } while (action < 1 || action > 3);

                switch (action)
                {
                    case 1:
                        {
                            Console.Clear();
                            aeroport.FullInfo();
                            Console.WriteLine("\n\n");
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            AddMain(ref aeroport);
                            break;
                        }
                    case 3:
                        {
                            rep = false;
                            break;
                        }
                }

            }


            Console.WriteLine("Good bye!");

            Console.ReadKey();
        }
    }
}
