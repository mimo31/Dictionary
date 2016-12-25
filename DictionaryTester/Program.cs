using System;
using System.Linq;
using System.Text;
using System.IO;
using DictionaryBase;

namespace DictionaryTester
{
    static class Program
    {
        static Dictionary Dictionary;
        static Random R = new Random();
        static bool DoCheck;

        static void Main(string[] args)
        {
            LoadTheDictionary();
            if (Dictionary.Name != null)
            {
                Console.WriteLine(Dictionary.Name + " loaded!");
            }
            else
            {
                Console.WriteLine("Dictionary loaded!");
            }
            if (Dictionary.Author != null)
            {
                Console.WriteLine("This Dictionary was written by " + Dictionary.Author + ".");
            }
            if (Dictionary.CreatedOn != DateTime.MinValue)
            {
                Console.WriteLine("It was created on " + Dictionary.CreatedOn.ToString() + ".");
            }
            DoCheck = Dictionary.DoCheck;
            //Console.OutputEncoding = Encoding.Unicode;
            Test();
        }

        static void LoadTheDictionary()
        {
            if (File.Exists("Dictionary.dic"))
            {
                Dictionary = new Dictionary("Dictionary.dic");
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Enter the path to the Dictionary:");
                    string readLine = Console.ReadLine();
                    if (File.Exists(readLine))
                    {
                        try
                        {
                            Dictionary = new Dictionary(readLine);
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(readLine + " isn't a valid Dictionary.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is no file at " + readLine + ".");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Test()
        {
            while (true)
            {
                if (DoCheck)
                {
                    DoCheckedTest();
                }
                else
                {
                    DoNotCheckedTest();
                }
                Console.WriteLine();
                Console.WriteLine("You have finished the test. Would you like to give it another try? (y, n)");
                char readChar = char.ToLower(Console.ReadKey().KeyChar);
                if (readChar == 'n')
                {
                    Console.WriteLine("Goodbye then!");
                    break;
                }
                else if (readChar != 'y')
                {
                    bool exit = false;
                    while (true)
                    {
                        Console.WriteLine("Please enter a y character or a n character.");
                        char readCharacter = char.ToLower(Console.ReadKey().KeyChar);
                        if (readCharacter == 'n')
                        {
                            Console.WriteLine();
                            Console.WriteLine("Goodbye then!");
                            exit = true;
                            break;
                        }
                        else if (readCharacter == 'y')
                        {
                            break;
                        }
                        Console.WriteLine();
                    }
                    if (exit)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Good luck:");
                Console.WriteLine();
            }
        }

        static void DoCheckedTest()
        {
            int entries = Dictionary.GetNumberOfEntries();
            bool[] doneRight = new bool[entries];
            int totalRight = 0;
            while (totalRight != entries)
            {
                int[] currentIndexes = new int[(int)((1 - Math.Pow(totalRight / (double)entries, 2)) * entries)];
                int nextIndex = 0;
                for (int i = 0; i < doneRight.Length; i++)
                {
                    if (!doneRight[i])
                    {
                        currentIndexes[nextIndex] = i;
                        nextIndex++;
                    }
                }
                bool[] available = new bool[entries];
                for (int i = 0; i < doneRight.Length; i++)
                {
                    available[i] = doneRight[i];
                }
                while (nextIndex != currentIndexes.Length)
                {
                    int generatedIndex = R.Next(entries - nextIndex);
                    for (int i = 0; i < available.Length; i++)
                    {
                        if (available[i])
                        {
                            generatedIndex--;
                            if (generatedIndex == -1)
                            {
                                currentIndexes[nextIndex] = i;
                                available[i] = false;
                                nextIndex++;
                                break;
                            }
                        }
                    }
                }
                currentIndexes = currentIndexes.OrderBy(v => R.NextDouble()).ToArray();
                for (int i = 0; i < currentIndexes.Length; i++)
                {
                    DictionaryEntry currentEntry = Dictionary.GetEntry(currentIndexes[i]);
                    Console.WriteLine();
                    Console.WriteLine(currentEntry.Question);
                    string input = Console.ReadLine();
                    ConsoleColor oldColor = Console.ForegroundColor;
                    if (input.Equals(currentEntry.Answer))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ForegroundColor = oldColor;
                        if (!doneRight[currentIndexes[i]])
                        {
                            doneRight[currentIndexes[i]] = true;
                            totalRight++;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(currentEntry.Answer);
                        Console.ForegroundColor = oldColor;
                        if (doneRight[currentIndexes[i]])
                        {
                            doneRight[currentIndexes[i]] = false;
                            totalRight--;
                        }
                    }
                }
            }
        }

        static void DoNotCheckedTest()
        {
            int[] indexes = Enumerable.Range(0, Dictionary.GetNumberOfEntries()).OrderBy(v => R.NextDouble()).ToArray();
            for (int i = 0; i < indexes.Length; i++)
            {
                Console.WriteLine();
                DictionaryEntry currentEntry = Dictionary.GetEntry(indexes[i]);
                Console.WriteLine(currentEntry.Question);
                Console.ReadLine();
                Console.WriteLine(currentEntry.Answer);
            }
        }
    }
}
