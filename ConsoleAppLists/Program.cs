using System;
using System.Collections.Generic;

namespace ConsoleAppLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayEx1();
            //ArrayEx2();
            //ArrayEx3();
            //ArrayEx4();

            //ListEx1();
            //ListEx2();

            //DictEx1();

        }//main

        static void DictEx1()
        {
            Dictionary<String, double> favNumbers = new Dictionary<string, double>();

            favNumbers.Add("Lucky", 17);
            favNumbers.Add("Pi", 3.14);

            //same as
            /*
            Dictionary<String, double> favNumbers = new Dictionary<string, double>
            {
                { "Lucky", 17 },
                { "Pi", 3.14 }
            };
            */

            Console.WriteLine(favNumbers.GetValueOrDefault("Pi"));
            Console.WriteLine(favNumbers.GetValueOrDefault("PI"));

            double result;
            //bool okay = favNumbers.TryGetValue("Lucky", out result);
            bool okay = favNumbers.TryGetValue("lucky", out result);

            if (okay)
            {
                Console.WriteLine("Results in: " + result);
            }
            else
            {
                Console.WriteLine("Not a valid key");
            }
        }

        static void ListEx1()
        {
            List<string> cars = new List<string>();

            cars.Add("BMW");
            cars.Add("Trabant");
            cars.Add("Porsche");
            cars.Add("Saab");

            int indexOfSaab = cars.IndexOf("Saab");

            Console.WriteLine("Index: " + indexOfSaab);
            Console.WriteLine(cars[indexOfSaab] + "\n-----------------------");

            foreach (String aCar in cars)
            {
                Console.WriteLine(aCar);
            }

            cars.Remove("Trabant");
            Console.WriteLine("Removed Trabant\n");

            foreach (String aCar in cars)
            {
                Console.WriteLine(aCar);
            }

        }

        static void ListEx2()
        {
            List<int> numbers = new List<int>();

            List<double> doubleList = new List<double>();

            numbers.Add(123);
            doubleList.Add(123);

            numbers.Add( (int)23.1 );// type cast - double - tripple cheack before you do it.

            doubleList.Add(23.2);

            //doubleList.AddRange(numbers); No, will not work
        }

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
