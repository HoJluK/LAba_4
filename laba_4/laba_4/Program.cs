using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
            int number = 1;
            string[] s = new string[7];
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(number + "." + "Enter string");
                s[i] = Console.ReadLine();
                number++;
            }
            foreach (string str in s)
            {
               
                string tempString = str.ToLower();
                char[] chars = tempString.ToCharArray();
                Console.WriteLine();
                if (chars[chars.Length - 1] == 'm' && chars[chars.Length - 2] == 'o' && chars[chars.Length - 3] == 'c' && chars[chars.Length - 4] == '.')
                {
                    Console.WriteLine(str);
                }
                for (int i = 0; i < chars.Length; i++)
                {
                    if (i < chars.Length - 4)
                    {
                        if ((chars[i] == '.' && chars[i + 1] == 'c' && chars[i + 2] == 'o' && chars[i + 3] == 'm') && (chars[i + 4] == ' ' || chars[i + 4] == '.' || chars[i + 4] == ',' || chars[i + 4].Equals("")))
                        {
                            Console.WriteLine(str);
                        }
                    }
                }
            }
            return s;
        }
        
        

        static string[] GetWords()
        {
            string[] arraystrings = new string[7];
            int length = 7, number;
            string[] s = new string[length];
            string[] sLower = new string[length];
            for (int i = 0; i < s.Length; i++)
            {
                number = i + 1;
                Console.Write(number + ". ");
                Console.WriteLine("Enter the string: ");
                s[i] = Console.ReadLine();
                Console.WriteLine();
                sLower[i] = s[i].ToLower();
            }
            Console.WriteLine();
            Console.WriteLine("Strings that contains \".com\":\n");
            for (int i = 0; i < sLower.Length; i++)
            {
                string[] sLowerWords = sLower[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < sLowerWords.Length; j++)
                {
                    if (sLowerWords[i].EndsWith(".com") || sLowerWords[i].EndsWith(".com.") || sLowerWords[i].EndsWith(".com,"))
                    {
                        number = i + 1;
                        Console.Write(number + ". ");
                        Console.WriteLine(s[i] + "\n");
                    }
                }
            }
            Console.WriteLine();
            int spaces = s[0].LastIndexOf(" ");
            int numOfStr = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (spaces > s[i].LastIndexOf(" "))
                {
                    spaces = s[i].LastIndexOf(" ");
                    numOfStr = i;
                }
            }
            Console.WriteLine("String with the smallest number of spaces: ");
            Console.WriteLine(s[numOfStr]);
            return arraystrings;
        }
        static string[] GetSplitString()
        {
            string mainString = Console.ReadLine();
            string[] arraystrings = mainString.Split(new[] { ' ', ',', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            return arraystrings;
        }
        static void PrintTrueLogins(string[] arraystrings)
        {
            for (int word = 0; word < arraystrings.Length; word++)
            {
                if ((int)arraystrings[word][0] >= 65 && (int)arraystrings[word][0] <= 90)
                {
                    if ((int)arraystrings[word][arraystrings[word].Length - 1] >= 48 && (int)arraystrings[word][arraystrings[word].Length - 1] <= 57)
                    {
                        if ((int)arraystrings[word][arraystrings[word].Length - 2] >= 48 && (int)arraystrings[word][arraystrings[word].Length - 2] <= 57)
                        {
                            if ((int)arraystrings[word][arraystrings[word].Length - 3] >= 48 && (int)arraystrings[word][arraystrings[word].Length - 3] <= 57)
                            {
                            }
                            else
                            {
                                for (int i = 1; i < arraystrings[word].Length - 2; i++)
                                {
                                    if ((int)arraystrings[word][i] >= 97 && (int)arraystrings[word][i] <= 122)
                                    {
                                        if (i == arraystrings[word].Length - 3)
                                        {
                                            Console.WriteLine(arraystrings[word]);
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        static string GetString()
        {
            Console.Write("Enter string: ");
            string mainString = Console.ReadLine();
            return mainString;
        }
        static void GetLogins(string mainString)
        {
            Regex regex = new Regex(@"[A-Z]\w+\d\d+");
            foreach (Match match in regex.Matches(mainString))
            {
                Console.WriteLine(match.Groups[0].Value);
            }
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
                case 6:
                    Console.WriteLine("Task 6");
                    six();
                    break;
                case 7:
                    Console.WriteLine("Task 7");
                    seven();
                    break;
                case 8:
                    Console.WriteLine("Task 8");
                    eigh();
                    break;
                case 9:
                    Console.WriteLine("Task 8");
                    ninth();
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
            UnShut();
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
            Console.WriteLine(arrayStrings);
            Console.ReadKey();
            Console.WriteLine("V.2.0");
            string[] arraystrings = GetWords();
            Console.WriteLine(arraystrings);
            Console.WriteLine();
            Console.ReadKey();
        }

        static void five()
        {
            Console.WriteLine("v.1.0");
            string[] arraystrings = GetSplitString();
            PrintTrueLogins(arraystrings);
            UnShut();
            Console.WriteLine("v.2.0");
            string mainString = GetString();
            GetLogins(mainString);
            UnShut();
        }

        static void six()
        {
            Console.WriteLine("Enter the string such as «15 + 36 = 51»: ");
            string arrays = Console.ReadLine();
            Regex numbers = new Regex(@"-?\d+");
            MatchCollection nums = numbers.Matches(arrays);
            foreach (Match match in nums)
            {
                int num = Convert.ToInt32(match.Value);
                Console.Write(num + "  ");
            }
            Console.ReadKey();
        }

        static void seven()
        {
            string[] trackList = new string[10];
            trackList[0] = "Gentle Giant – Free Hand [06:15]";
            trackList[1] = "Supertramp – Child Of Vision [07:27]";
            trackList[2] = "Camel – Lawrence [10:46]";
            trackList[3] = "Yes – Don’t Kill The Whale [03:55]";
            trackList[4] = "10CC – Notell Hotel [04:58]";
            trackList[5] = "Nektar – King Of Twilight [04:16]";
            trackList[6] = "The Flower Kings – Monsters & Men [21:19]";
            trackList[7] = "Focus – Le Clochard [01:59]";
            trackList[8] = "Pendragon – Fallen Dream And Angel [05:23]";
            trackList[9] = "Kaipa – Remains Of The Day [08:02]";
            int digitMin = 0;
            int digitSec = 0;
            decimal sum = 0;
            string shortestSong = string.Empty;
            string longestSong = string.Empty;
            int minDuration = int.MaxValue, maxDuration = 0;
            int[] durations = new int[trackList.Length];
            int minDifference = int.MaxValue, firstTrackIndex = 0, secondTrackIndex = 0;
            for (int i = 0; i < trackList.Length; i++)
            {
                Console.WriteLine(trackList[i]);
                Console.WriteLine();
                Regex minutes = new Regex(@"(\d{2})(?=:)");
                Regex seconds = new Regex(@"(?<=:)(\d{2})");
                MatchCollection min = minutes.Matches(trackList[i]);
                MatchCollection sec = seconds.Matches(trackList[i]);
                foreach (Match m in min)
                {
                    digitMin = Convert.ToInt32((m.Value));
                    Console.WriteLine("Minutes: " + digitMin);
                    sum += digitMin * 60;
                }
                foreach (Match s in sec)
                {
                    digitSec = Convert.ToInt32((s.Value));
                    Console.WriteLine("Seconds: " + digitSec);
                    sum += digitSec;
                }
                Console.WriteLine();

                if (digitMin > maxDuration)
                {
                    maxDuration = digitMin;
                    longestSong = trackList[i];
                }
                if (digitMin < minDuration)
                {
                    minDuration = digitMin;
                    shortestSong = trackList[i];
                }
                durations[i] = digitMin * 60 + digitSec;
            }
            for (int q = 0; q < durations.Length; q++)
            {
                for (int w = 0; w < durations.Length; w++)
                {
                    if (q == w)
                    {
                        continue;
                    }
                    if (Math.Abs(durations[q] - durations[w]) < minDifference)
                    {
                        firstTrackIndex = q;
                        secondTrackIndex = w;
                        minDifference = Math.Abs(durations[q] - durations[w]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Summary time is " + sum + " sec");
            Console.WriteLine("The shortest song is " + shortestSong);
            Console.WriteLine("The longest song is " + longestSong);
            Console.WriteLine("Songs that have minimal difference of durations: {0} and {1}", trackList[firstTrackIndex], trackList[secondTrackIndex]);
            Console.ReadKey();
        }
    
        static void eigh()
        {
            Console.WriteLine(" Enter 1(Atbash), 2(Vernam), 3(permutation)");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Atbash");
                Console.WriteLine("Enter the text: ");
                string s = Console.ReadLine();
                s = s.ToLower();
                Console.WriteLine();
                string output = string.Empty;
                foreach (char ch in s)
                {
                    if (char.IsLetter(ch))
                    {
                        output += (char)(219 - ch);
                    }
                    else
                    {
                        output += ch;
                    }
                }

                Console.WriteLine(output);
                Console.ReadKey();
            }
            if (number == 2)
            {
                Console.WriteLine("Vernam");
                Console.WriteLine("Enter the text: ");
                string s = Console.ReadLine();
                s = s.ToLower();
                Console.WriteLine("Enter the key: ");
                string key = Console.ReadLine();
                if (key.Length != s.Length)
                    return;
                string CipherText = string.Empty;
                for (int i = 0; i < s.Length; i++)
                {
                    CipherText += (char)(s[i] ^ key[i]);
                }
                Console.WriteLine(CipherText);
                Console.ReadKey();
            }
            if (number == 3)
            {
                Console.WriteLine("Enter the text: ");
                string s = Console.ReadLine();
                s = s.ToLower();
                Console.WriteLine("Enter the key: ");
                string permutationKey = Console.ReadLine();
                string permutatuionOutput = string.Empty;
                for (int i = 0; i < s.Length; i++)
                {
                    string chKey = permutationKey[i].ToString();
                    int digitKey = int.Parse(chKey) - 1;
                    permutatuionOutput += s[digitKey];
                }
                Console.WriteLine(permutatuionOutput);
                Console.ReadKey();
            }
        }

        static void ninth()
        {
            Console.WriteLine("string");
            Console.WriteLine("Enter the text: ");
            string s = Console.ReadLine();
            s = s.ToLower();
            string[] words = s.Split(new char[] { ' ', ',', '.' });
            foreach (string word in words)
            {
                char[] charWord = word.ToCharArray();
                if (charWord[0] == charWord[charWord.Length - 1])
                {
                    s = s.Replace(word, "");
                }
            }
            Console.WriteLine();
            Console.WriteLine(s);
            Console.ReadKey();

           Console.WriteLine("StringBuilder");
            s = s.ToLower();
            string[] worods = s.Split(new char[] { ' ', ',', '.' });
            foreach (string word in words)
            {
                if (word[0] == word[word.Length - 1])
                {
                    s = s.Replace(word, "");
                }
            }
            Console.WriteLine();
            Console.WriteLine(s);
        }


    }
}
