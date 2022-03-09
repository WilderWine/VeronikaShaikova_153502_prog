using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153502_ShaikovaVeronika
{
    class Program
    {
        static void Main(string[] args)
        {
            float fst_val, scnd_val, trd_val;
            string frst_val_strg, scnd_val_strg;

            Console.WriteLine("Input the first value to be divided: ");


            frst_val_strg = Console.ReadLine();

            Console.WriteLine("Input a divider: ");

            scnd_val_strg = Console.ReadLine();

            fst_val = float.Parse(frst_val_strg);
            scnd_val = float.Parse(scnd_val_strg);

            trd_val = fst_val / scnd_val;


            Console.WriteLine(trd_val.ToString());

            Console.ReadLine();

        }
    }
}
