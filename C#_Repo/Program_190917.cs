using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 5;
            var count = 3;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine("{0}{1}", byte.MinValue, byte.MaxValue);

            //int i = 4;
            //byte b = (byte)i; //Casting

            float fl = 1.0f;
            int i1 = (int)fl;

            //Console.WriteLine(b);
            Console.WriteLine(i1);

            string s = "56";
            int i = Convert.ToInt32(s);

            //int j = i;
            int j = int.Parse(s);
            Console.WriteLine(s);

            int ab = 1;
            //int b = ab++;
            int b = ++ab;
            Console.WriteLine("{0} {1}", ab, b);

            try
            {
                var bb = "2312360";
                byte ii = Convert.ToByte(bb);
                Console.WriteLine(ii);
                //int jj = int.Parse(bb);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot be converted");
            }

          
        }
    }
}

