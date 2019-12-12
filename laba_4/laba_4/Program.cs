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

        static string[] GetStrings()
        {
            Console.Write("Enter offer :");
            string mainString = Console.ReadLine();
            string[] arrayStrings = mainString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return arrayStrings;
        }
        static string GetNewString(string[] arrayStrings)
        {
            string returnString = String.Empty;
            int counterWords = 1;

            for (int i = 0; i <= arrayStrings.Length - 1; i++)
            {
                char[] arrayChars = arrayStrings[i].ToCharArray();
                string tmpstring = String.Empty;
                if (arrayChars.Length > 0)
                {
                    if (arrayChars[arrayChars.Length - 1] == '-')
                    {
                        tmpstring = "-";
                    }
                    else
                    {
                        if (arrayChars[arrayStrings[i].Length - 1] == ',' || arrayChars[arrayStrings[i].Length - 1] == '!' || arrayChars[arrayStrings[i].Length - 1] == '?' || arrayChars[arrayStrings[i].Length - 1] == '.')
                        {
                            for (int j = 0; j < arrayChars.Length; j++)
                            {
                                if (j < arrayChars.Length - 1)
                                {
                                    tmpstring += arrayChars[j];
                                }
                                else
                                {
                                    tmpstring += "(" + counterWords++ + ")" + arrayChars[arrayChars.Length - 1];
                                }
                            }
                        }
                        else
                        {
                            tmpstring = new string(arrayChars) + "(" + counterWords++ + ")";
                        }
                    }
                }
                returnString += tmpstring + " ";
            }
            return returnString;
        }

        
        static string GetNewString2(string[] arrayStrings)
        {
            string returnString = String.Empty;
            int counterWords = 1;
            for (int i = 0; i <= arrayStrings.Length - 1; i++)
            {
                if (arrayStrings[i] == "-")
                {

                }
                else
                {
                    if (arrayStrings[i][arrayStrings[i].Length - 1] == ',' || arrayStrings[i][arrayStrings[i].Length - 1] == '!' || arrayStrings[i][arrayStrings[i].Length - 1] == '?' || arrayStrings[i][arrayStrings[i].Length - 1] == '.')
                    {
                        arrayStrings[i] = arrayStrings[i].Substring(0, arrayStrings[i].Length - 1) + "(" + counterWords++ + ")" + arrayStrings[i][arrayStrings.Length + 2];
                    }
                    else
                    {
                        arrayStrings[i] = arrayStrings[i] + "(" + counterWords++ + ")";
                    }
                }
                returnString += arrayStrings[i] + " ";
            }
            return returnString;
        }

        static string GetStringWithoutSpace(char[] arrayChars)
        {
            string returnString = null;
            for (int i = 0; i <= arrayChars.Length - 1; i++)
            {
                if (arrayChars[i] != ' ')
                {
                    returnString += arrayChars[i];
                }
            }
            return returnString;
        }
        static string[] GtStrings()
        {
            Console.WriteLine("Enter string");
            string mainString = Console.ReadLine().ToLower();
            string[] arrayStrings = mainString.Split(new[] { ' ', ',', ':', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
            return arrayStrings;
        }
        static string GtNewString(string[] arrayStrings)
        {
            string returnString = String.Empty;
            for (int i = arrayStrings.Length - 1; i >= 0; i--)
            {
                char[] arrayChars = arrayStrings[i].ToCharArray();
                {
                    if (i == arrayStrings.Length - 1)
                    {
                        arrayChars[0] = Convert.ToChar(arrayChars[0]);
                    }
                }
                if (arrayChars[0] == '-' || arrayChars[arrayChars.Length - 1] == '-')
                {
                    if (arrayChars[0] == '-')
                    {
                        arrayChars[0] = ' ';
                    }
                    else
                    {
                        arrayChars[arrayChars.Length - 1] = ' ';
                    }
                }
                arrayStrings[i] = GetStringWithoutSpace(arrayChars);
                returnString += arrayStrings[i] + " ";
            }
            return returnString;
        }


        static string GtNewString2(string[] arrayStrings)
        {
            string resultString = String.Empty;
            for (int i = arrayStrings.Length - 1; i >= 0; i--)
            {
                if (i == arrayStrings.Length - 1)
                {
                    arrayStrings[arrayStrings.Length - 1] = arrayStrings[arrayStrings.Length - 1].Substring(0, 1).ToUpper() + arrayStrings[arrayStrings.Length - 1].Remove(0, 1);
                }
                if (i == 0)
                {
                    arrayStrings[0] = arrayStrings[0].Substring(0, 1).ToLower() + arrayStrings[0].Remove(0, 1);
                }
                if (arrayStrings[i].Substring(0, 1) == "-")
                {
                    continue;
                }
                resultString += arrayStrings[i] + " ";
            }
            return resultString;
        }


        static string GetStringWithoutSpace4(char[] arrayChars)
        {
            string returnString = null;
            for (int i = 0; i <= arrayChars.Length - 1; i++)
            {
                if (arrayChars[i] != ' ')
                {
                    returnString += arrayChars[i];
                }
            }
            return returnString;
        }
        static string[] GetStrings4()
        {
            Console.WriteLine("Enter string ");
            string mainString = Console.ReadLine().ToLower();
            string[] arrayStrings = mainString.Split(new[] { ' ', ',', ':', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
            return arrayStrings;
        }
        static string GetNewString4(string[] arrayStrings)
        {
            string returnString = String.Empty;
            for (int i = arrayStrings.Length - 1; i >= 0; i--)
            {
                char[] arrayChars = arrayStrings[i].ToCharArray();
                {
                    if (i == arrayStrings.Length - 1)
                    {
                        arrayChars[0] = char.ToUpper(arrayChars[0]);
                    }
                }
                if (arrayChars[0] == '-' || arrayChars[arrayChars.Length - 1] == '-')
                {
                    if (arrayChars[0] == '-')
                    {
                        arrayChars[0] = ' ';
                    }
                    else
                    {
                        arrayChars[arrayChars.Length - 1] = ' ';
                    }
                }
                arrayStrings[i] = GetStringWithoutSpace4(arrayChars);
                returnString += arrayStrings[i] + " ";
            }
            return returnString;
        }

        static string[] GetWords()
        {
            Console.WriteLine("Enter string");
            string mainstring = Console.ReadLine();
            string[] arraystrings = mainstring.Split(new[] { ' ', ',', ':', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
            return arraystrings;
        }
        static string GtNewString4(string[] arraystrings)
        {
            string resultstring = String.Empty;
            for (int i = arraystrings.Length - 1; i >= 0; i--)
            {
                if (i == arraystrings.Length - 1)
                {
                    arraystrings[arraystrings.Length - 1] = arraystrings[arraystrings.Length - 1].Substring(0, 1).ToUpper() + arraystrings[arraystrings.Length - 1].Remove(0, 1);
                }
                if (i == 0)
                {
                    arraystrings[0] = arraystrings[0].Substring(0, 1).ToLower() + arraystrings[0].Remove(0, 1);
                }
                if (arraystrings[i].Substring(0, 1) == "-")
                {
                    continue;
                }
                resultstring += arraystrings[i] + " ";
            }
            return resultstring;
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
                    Console.WriteLine("Task 2");
                    two();
                    break;
                case 3:
                    Console.WriteLine("Task 3");
                    three();
                    break;
                case 4:
                    Console.WriteLine("Task 4");
                    four();
                    break;
                case 5:
                    Console.WriteLine("Task 5");
                    five();
                    break;

            }
        }
        static void zero()
        {
            Console.WriteLine("OH, there's nothing here, it's zero");
            Console.ReadKey();
        }
        static void one()
        {
            Console.WriteLine("Way array");
            GetString(out mainString);
            CheckString(mainString);
            UnShut();
            Console.WriteLine("Way string");
            GetString2(out mainString);
            CheckString2(mainString);
            UnShut2();
        }
        static void two()
        {
            Console.WriteLine("Way array");
            string[] arrayStrings = GetStrings();
            Console.WriteLine(GetNewString(arrayStrings));
            Console.WriteLine("Way string");
            Console.WriteLine(GetNewString2(arrayStrings));
            Console.ReadKey();
        }

        static void three()
        {
            Console.WriteLine("Way array");
            string[] arrayStrings = GtStrings();
            Console.WriteLine(GtNewString(arrayStrings));
            Console.WriteLine("Way string");
            Console.WriteLine(GtNewString2(arrayStrings));
            Console.ReadKey();
        }

        static void four()
        {
            Console.WriteLine("V.1.0");
            string[] arrayStrings = GetStrings4();
            Console.WriteLine(GetNewString4(arrayStrings));
            Console.ReadKey();
            Console.WriteLine("V.2.0");
            string[] arraystrings = GetWords();
            Console.WriteLine(GtNewString4(arraystrings));
            Console.WriteLine();
            Console.ReadKey();
        }

        static void five()
        {

        }
    }
}
