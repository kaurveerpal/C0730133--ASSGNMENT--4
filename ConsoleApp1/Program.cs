﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace c0730133
{
    class Program
    {
        ArrayList Beowulf;
        int counterletters = 0;
        int countSpaces = 0;
        static void Main(string[] args)
        {
            Program a = new Program();
            a.Beowulf = new ArrayList();
            a.ReadTextFiles();
        }

        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {

            using (StreamReader sr = new StreamReader("U:/Users/730133/beowulf.txt"))
            {
                string line;
                int counter = 0;
                int a = 0, myWord = 1;
                int averageLetterPerWord;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Beowulf.Add(line);
                    FindNumberOfBlankSpaces(line);
                    counter++;

                    while (a <= line.Length - 1)
                    {
                        if (line[a] == ' ' || line[a] == '\n' || line[a] == '\t')
                        {
                            myWord++;
                        }
                        a++;
                    }
                    a = 0;

                }

                averageLetterPerWord = counterletters / countSpaces;

                Console.WriteLine("\n\n\n\n********************************\nThe number of lines in the paragraph is " + counter);
                Console.WriteLine("The number of words in paragraph is " + myWord);
                Console.WriteLine("The number of average letters per word is " + averageLetterPerWord);
                Console.ReadLine();
            }

        }
        public int FindNumberOfBlankSpaces(string line)
        {
            foreach (char c in line)
            {
                if (char.IsLetter(c)) { counterletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }
    }
}