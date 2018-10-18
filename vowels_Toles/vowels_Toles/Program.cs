using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace vowels_Toles
{
    class Program
    {
        static void Main(string[] args)
        {
            int countVowel = Reggie(@"[AEIOUaeiou]", "Please enter a word or sentence: ");
            Console.WriteLine("There are/is " + countVowel + " vowels.");
            Rerun();
        }

        static int Reggie(string pleaseWork, string prompt)
        {
            while (true)
            {
                //prompt use to user to give us a string
                Console.WriteLine(prompt);
                string answer = Console.ReadLine();
                string[] sentence = answer.Split(' ');
                int countVowel = 0;

                foreach (var letter in sentence)
                {
                    for (int i = 0; i < answer.Length; i++)
                    {
                        if (Regex.IsMatch(answer[i].ToString(), pleaseWork))
                        {
                            countVowel++;
                        }

                    }
                }
                return countVowel;

            }

        }
        static void Rerun()
        {

            Console.WriteLine("\nCheck another line? y/n");

            string repeat = Console.ReadLine().ToLower();

            if (repeat == "y" || repeat == "yes")
            {
                Reggie(@"[AEIOUaeiou]", "Please enter a word or sentence: ");
            }

            else
            {
                Console.WriteLine("Goodbye");
                Environment.Exit(0);
            }

        }
    }



}