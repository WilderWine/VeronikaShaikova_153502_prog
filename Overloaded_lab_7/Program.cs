using System;
using System.Collections.Generic;


namespace Overloaded_lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equation> eqs = new List<Equation>(0);

            eqs.Add(new Equation());
            eqs.Add(new Equation(17, 0, 8));
            eqs.Add(new Equation(16, 0, -30));
            eqs.Add(new Equation(1, 14, 7));
            eqs.Add(new Equation(781));
            eqs.Add(new Equation(14, 7));

            bool rep = true;
            while(rep)
            {
                Console.Clear();
                for(int i = 0; i < eqs.Count; i++)
                {
                    Console.WriteLine((i+1).ToString() + "  " + eqs[i].Solve() + "\n");
                    
                }

                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
                int action = 0;
                Console.WriteLine("Choose action:");
                Console.WriteLine("1. Add equation\n2. Change equation\n3.Equation to number and back\n4. Exit");
                he1:
                while (!int.TryParse(Console.ReadLine(), out action)) ;
                if (action < 1 || action > 4) goto he1;

                switch (action)
                    {
                        case 1:
                            {
                                int a, b, c;
                                Console.WriteLine("input integer a:");
                                while (!int.TryParse(Console.ReadLine(), out a)) ;
                                    Console.WriteLine("input integer b:");
                                while (!int.TryParse(Console.ReadLine(), out b)) ;
                                    Console.WriteLine("input integer c");
                                while (!int.TryParse(Console.ReadLine(), out c)) ;
                                eqs.Add(new Equation(a, b, c));
                                    break;
                                
                            }
                        case 2:
                            {
                            Console.WriteLine($"Coose number 1 to " + (eqs.Count).ToString()) ;
                            int el = 1;
                            he2:
                            while (!int.TryParse(Console.ReadLine(), out el)) ;
                            if (el < 1 || el > (eqs.Count)) goto he2;

                            int type = 0;
                            Console.WriteLine("\n1.  + (value)\n2.  + (another equation)\n3.  - (value)\n4.  - (another equation)\n5.  *\n6  /\n7.  ++\n8. --\n.another:  new a, b and c");
                            while (!int.TryParse(Console.ReadLine(), out type)) ;
                            switch (type)
                            {
                                case 1:
                                    {
                                        int val = 0;
                                        while (!int.TryParse(Console.ReadLine(), out val)) ;
                                        eqs[el - 1] += val;
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine($"Coose number 1 to " + (eqs.Count).ToString());
                                        int elem = 1;
                                    he:
                                        while (!int.TryParse(Console.ReadLine(), out elem)) ;
                                        if (elem < 1 || elem > (eqs.Count)) goto he;
                                        eqs[el - 1] += eqs[elem - 1];
                                        break;
                                    }
                                case 3:
                                    {
                                        int val = 0;
                                        while (!int.TryParse(Console.ReadLine(), out val)) ;
                                        eqs[el - 1] -= val;
                                      
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine($"Coose number 1 to " + (eqs.Count).ToString());
                                        int elem = 1;
                                    h:
                                        while (!int.TryParse(Console.ReadLine(), out elem)) ;
                                        if (elem < 1 || elem > (eqs.Count)) goto h;
                                        eqs[el - 1] -= eqs[elem - 1];
                                       
                                        break;
                                    }
                                case 5:
                                    {
                                        int val = 0;
                                        while (!int.TryParse(Console.ReadLine(), out val)) ;
                                        eqs[el - 1] *= val;
                                      
                                        break;
                                    }
                                case 6:
                                    {
                                        int val = 1;
                                        while (!int.TryParse(Console.ReadLine(), out val)) ;
                                        if (val !=0)
                                        eqs[el - 1] /= val;
                                        
                                        break;
                                    }
                                case 7:
                                    {
                                        
                                        eqs[el - 1]++;
                                        
                                        break;
                                    }
                                case 8:
                                    {
                                        eqs[el - 1]--;
                                        break;
                                    }
                                default:
                                    {
                                        int a, b, c;
                                        Console.WriteLine("input new a:");
                                        while (!int.TryParse(Console.ReadLine(), out a)) ;
                                        Console.WriteLine("input new b:");
                                        while (!int.TryParse(Console.ReadLine(), out b)) ;
                                        Console.WriteLine("input new c");
                                        while (!int.TryParse(Console.ReadLine(), out c)) ;

                                        eqs[el - 1].A = a; eqs[el - 1].B = b; eqs[el - 1].C = c;
                                        break;
                                    }

                            }


                            break;
                            }
                        case 3:
                            {
                            Console.WriteLine($"Coose number 1 to " + (eqs.Count).ToString());
                            int el = 1;
                        he4:
                            while (!int.TryParse(Console.ReadLine(), out el)) ;
                            if (el < 1 || el > (eqs.Count)) goto he4;

                            int a = (int)eqs[el - 1];

                            Console.WriteLine("int a from equation  =  " + a.ToString());

                            eqs[el - 1] = (Equation)a;

                            Console.WriteLine("Equation back from a:    " + eqs[el - 1].ToString());

                            Console.ReadKey();

                            break;
                            }
                       
                        case 4:
                            {
                                rep = false;
                                break;
                            }
                    }

                
                
            }

        }
    }
}
