using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4
{
    class Program
    {
        static string mainString;
        static void GetString(out string mainString)
        {
            for (int i = 0; ; i++)
            {
                Console.Write("Enter offer : ");
                mainString = Console.ReadLine();
                if (mainString == "")
                {
                    Console.Write("ERROR\n");
                    continue;
                }
                break;
            }
        }
        static void CheckString(string mainString)
        {
            bool findFlag = false;
            char[] charArray = mainString.ToCharArray();
            Console.Write("All characters that enter once: ");
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int k = 0; k < charArray.Length; k++)
                {
                    if (i != k)
                    {
                        if (charArray[i] == charArray[k])
                        {
                            findFlag = true;
                        }
                    }
                }
                if (findFlag == false)
                {
                    Console.Write(charArray[i]);
                }
                else
                {
                    findFlag = false;
                }
            }
        }
        static void UnShut()
        {
            Console.WriteLine();
            Console.ReadKey();
        }

        static void GetString2(out string mainString)
        {
            for (int i = 0; ; i++)
            {
                Console.Write("Enter offer: ");
                mainString = Console.ReadLine(); ;
                if (mainString == "")
                {
                    Console.Write("ERROR\n");
                    continue;
                }
                break;
            }
        }
        static void CheckString2(string mainString)
        {
            Console.Write("All characters that enter once: ");
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString.IndexOf(mainString[i]) == mainString.LastIndexOf(mainString[i]))
                {
                    Console.Write(mainString[i]);
                }
            }
        }
        static void UnShut2()
        {
            Console.WriteLine();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter job number --");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 0:
                    Console.WriteLine("Task :0");
                    zero();
                    break;
                case 1:
                    Console.WriteLine("Task 1");
                    one();
                    break;
                case 2:
                    Console.WriteLine("Task 1");
                    two();
                    break;

            }
        }
        static void zero()
        {
            Console.WriteLine("Enter n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter k:");
            int k = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] mas = new int[n];

            Console.WriteLine("Array");
            for (int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(10);
                Console.Write("{0} ", mas[i]);
            }
            Console.WriteLine("\n Array 2 \n");
            //for (int i = k; i < n; i++)
            //{
            //    Console.Write("{0} ", mas[i]);
            //}
            //for (int i = 0; i < k; i++)
            //{

            //    Console.Write("{0} ", mas[i]);
            //}
            //Console.WriteLine();

            for (int i = 0; i < k; i++)
            {
                int y = 1;
                int a = 0;
                for (i = k; i < n; i++)
                {
                    int x = mas[a];
                    mas[i - y] = x;
                    y++;
                    a++;
                    Console.Write("{0} ", mas[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("{0} ", mas[i]);
            }

            Console.ReadKey();
        }
        static void one()
        {
            GetString(out mainString);
            CheckString(mainString);
            UnShut();
            Console.WriteLine("Task 1 v:2.0");
            GetString2(out mainString);
            CheckString2(mainString);
            UnShut2();
        }
        static void two()
        {

        }
        
    }
}
