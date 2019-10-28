using System;

namespace ConsoleAppLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayEx1();
            ArrayEx2();
            ArrayEx3();
            ArrayEx4();

        }//main



        static void ArrayEx1()
        {
            string[] names = new string[7];

            names[0] = "Ulf";
            names[1] = "Rand";
            names[2] = "Hasse";
            names[3] = "Reinhardt";
            names[4] = "Mikael";
            names[5] = "Philip";
            names[6] = "Peter";

            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine(names[index]);
            }

            Console.WriteLine("-------------------------------------");

            for (int index = names.Length - 1; 0 <= index; index--)
            {
                Console.WriteLine(names[index]);
            }

        }//ArrayEx1

        static void ArrayEx2()
        {
            string[] names = new string[] { "Ulf", "Rand", "Hasse", "Reinhardt", "Mikael", "Philip", "Peter" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }//ArrayEx2

        static void ArrayEx3()
        {
            int[,] tenMultiTabels = new int[10, 10];

            //foreach (int number in tenMultiTabels)
            //{
            //    Console.WriteLine(number);
            //}

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    tenMultiTabels[y, x] = (y + 1) * (x + 1);
                }
            }

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write(tenMultiTabels[x, y] + "\t");
                }
                Console.WriteLine();// only to make a new row
            }
        }

        static void ArrayEx4()
        {
            int x_Multi = 10;
            int y_Multi = 100;

            int[,] tenMultiTabels = new int[y_Multi, x_Multi];

            for (int y = 0; y < y_Multi; y++)
            {
                for (int x = 0; x < x_Multi; x++)
                {
                    tenMultiTabels[y, x] = (y + 1) * (x + 1);
                }
            }

            for (int y = 0; y < y_Multi; y++)
            {
                for (int x = 0; x < x_Multi; x++)
                {
                    Console.Write(tenMultiTabels[y, x] + "\t");
                }
                Console.WriteLine();// only to make a new row
            }
        }
    }
}
