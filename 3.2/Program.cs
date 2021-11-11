using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a = 1,d=0,S;
                do
                {
                    d = 2.54;
                    S = a * d;
                    Console.WriteLine("|{0}|{1}|", a, S);
                    a ++;
                } while (a!=21);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
