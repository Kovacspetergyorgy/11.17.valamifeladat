using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nemnemnem
{
    internal class Program
    {

        struct kerders1
        {
            public string kerdes;
            public string val1;
            public string val2;
            public string val3;
            public string val4;
            public string hval;

           

        }
        static List<kerders1> list = new List<kerders1>();
        static void nem(string path)
        {
            StreamReader file = new StreamReader(path);
            

            while (!file.EndOfStream)
            {
                string[] data = file.ReadLine().Split('\t');
                kerders1 temp = new kerders1();
                temp.kerdes = data[0];
                temp.val1 = data[1];
                temp.val2 = data[2];
                temp.val3 = data[3];
                temp.val4 = data[4];
                temp.hval = data[5];

                list.Add(temp);
            }
            file.Close();

        }

        static void Main(string[] args)
        {

            nem("kerdesek1.txt");

            Console.WriteLine("Kivz: ");
            Console.WriteLine("1.Kérdés");
            foreach (var item in list)
            {
                Console.WriteLine(item.kerdes);
                Console.WriteLine("     a,"+item.val1);
                Console.WriteLine("     b,"+item.val2);
                Console.WriteLine("     c,"+item.val3);
                Console.WriteLine("     d,"+item.val4);
                Console.WriteLine("     ");
                Console.WriteLine("Válasz betűje:");
                string asd = Console.ReadLine();
                if (asd == item.hval)
                {
                    Console.WriteLine("     ");
                    Console.WriteLine("Helyes");
                    Console.WriteLine("     ");

                }
                else
                {
                    Console.WriteLine("     ");
                    Console.WriteLine("Helytelen");
                    Console.WriteLine("     ");

                }
            }
            



            Console.ReadKey();
        }

    }
}

