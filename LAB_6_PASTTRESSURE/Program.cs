using System;

namespace LAB_6_PASTTRESSURE
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool rep = true;

            while (rep)
            {
                Console.Clear();
                Console.WriteLine("Creating object of traktor:\n");
                Traktor traktor = new Traktor();
                Console.WriteLine(traktor.funk1());
                traktor.funk2();
                traktor.NewFunk();
                Console.WriteLine("Max speed\t=\t" + traktor.speed().ToString());
                Console.WriteLine("\n\n");


                Console.WriteLine("Creating object of car:\n");
                Car car = new Car();
                Console.WriteLine(car.funk1());
                car.funk2();
                car.NewFunk();
                Console.WriteLine("Max speed\t=\t" + car.speed().ToString());
                Console.WriteLine("\n\n");

                Console.WriteLine("Creating object of zhigulj:\n");
                Zhigulj zhigulj = new Zhigulj();
                Console.WriteLine(zhigulj.funk1());
                zhigulj.funk2();
                zhigulj.NewFunk();
                Console.WriteLine("Max speed\t=\t" + zhigulj.speed().ToString());
                Console.WriteLine("\n\n");

                Console.WriteLine("Creating object of sportcar:\n");
                SportCar sportcar = new SportCar();
                Console.WriteLine(sportcar.funk1());
                sportcar.funk2();
                sportcar.NewFunk();
                Console.WriteLine("Max speed\t=\t" + sportcar.speed().ToString());
                Console.WriteLine("\n\n");
                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
                Console.WriteLine("\n\n");
                int action = 1;
                do
                {
                    Console.WriteLine("Choose action to continue: \n1.  set anoter speed\n2.  exit");
                    action = int.Parse(Console.ReadLine());
                } while (action != 1 && action != 2);
                switch (action)
                {
                    case 1:
                        {
                            int obj = 0;
                            do
                            {
                                Console.WriteLine("\nChoose object:\n1.  traktor\n2.  car\n3.zhigul (but car's speed will be changed)\n4.sportcar");
                                obj = int.Parse(Console.ReadLine());
                            } while (obj < 1 || obj > 4);
                            Console.WriteLine("input new speed:");
                            int speed = int.Parse(Console.ReadLine());

                            switch (obj)
                            {
                                case 1:
                                    {
                                        traktor.SetSpeed(speed);
                                        break;
                                    }
                                case 2:
                                    {
                                        car.SetSpeed(speed);
                                        break;
                                    }
                                case 3:
                                    {
                                        zhigulj.SetSpeed(speed);
                                        break;
                                    }
                                case 4:
                                    {
                                        sportcar.SetSpeed(speed);
                                        break;
                                    }
                            }



                            break;
                        }
                    case 2:
                        {
                            rep = false;
                            break;
                        }
                }
            }

            Console.ReadKey();

        }
    }
}
