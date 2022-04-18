using System;

namespace AEROPORT_LAB_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport1 AirWaffen = new Airport1();
            int action = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("What'd you like to do now?" +
                    "\n1  ─  Add ticket" +
                    "\n2  ─  Add customer" +
                    "\n3  ─  Search by customer" +
                    "\n4  ─  Choose a customer and sell new ticket:" +
                    "\n5  ─  Whole info"+
                    "\nother  ─  exit");
                action = int.Parse(Console.ReadLine());
                
                switch (action)
                {
                    case 1:
                        {
                            string dest; int price;
                            Console.Clear();
                            Console.WriteLine("Input destination point:\t");
                            dest = Console.ReadLine();
                            Console.WriteLine("\nInput cost for this ticket:\t");
                            price = int.Parse(Console.ReadLine());
                            AirWaffen.AddTicket(dest, price);
                            break;
                        }
                    case 2:
                        {
                            string n = ""; string p = ""; int t = 0;
                            Console.Clear();
                            Console.WriteLine("Input name of the customer:\t");
                            n = Console.ReadLine();
                            Console.WriteLine("Input passport number of the customer:\t");
                            p = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("\nChoose type of the customer:" +
                                    "\n1. Standart" +
                                    "\n2. VIP" +
                                    "\n3. Child");
                                t = int.Parse(Console.ReadLine());

                            } while (t != 1 && t != 2 && t != 3);
                            switch (t)
                            {
                                case 1:
                                    {
                                        AirWaffen.AddCustomer(n, p, CType.standart);
                                        break;
                                    }
                                case 2:
                                    {
                                        AirWaffen.AddCustomer(n, p, CType.VIP);
                                        break;
                                    }
                                case 3:
                                    {
                                        AirWaffen.AddCustomer(n, p, CType.child);
                                        break;
                                    }
                            }
                            
                            break;
                        }
                    case 3:
                        {

                            int N;
                            Console.WriteLine("Choose a customer for search:\n");
                            Console.WriteLine(AirWaffen.Customerrrs());
                            N = int.Parse(Console.ReadLine());
                            if (N > 0 && N <= Airport1.GetCustomers().Count)
                            {
                                Console.WriteLine(AirWaffen.SearchName(Airport1.GetCustomers()[N-1].name));
                            }

                                                         
                            
                            Console.ReadKey();
                            break;
                        }
                  
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Total cost:\t" + AirWaffen.GetWholeCost().ToString() + "\n");
                            for (int i = 0; i < Airport1.GetCustomers().Count; i++)
                                Console.WriteLine(AirWaffen.SearchName(Airport1.GetCustomers()[i].name));
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            int N;
                            Console.WriteLine("Choose a customer from the list:\n");
                            Console.WriteLine(AirWaffen.Customerrrs());
                            N = int.Parse(Console.ReadLine());
                            if (N > 0 && N <= Airport1.GetCustomers().Count)
                            {
                                //Console.Clear();
                                AirWaffen.LogIn(N);
                                Console.WriteLine("Chose, where to send this person:\n");
                                Console.WriteLine(AirWaffen.Tickeeets());
                                int NN = int.Parse(Console.ReadLine());
                                if (NN > 0 && NN <=Airport1.GetTicketList().Count)
                                AirWaffen.SellTicket(NN);
                                AirWaffen.LogOut();
                            }
                              
                            
                            break;
                        }
                    default: break;
                }




            } while (action >=1 && action <=5);







        }
    }
}
