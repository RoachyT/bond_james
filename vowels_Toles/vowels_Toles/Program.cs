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
            Reggie(@"[AEIOUaeiou]", "Please enter a word or sentence: ");

        }

        static void Reggie(string pleaseWork, string prompt)
        {
            while (true)
            {
                //prompt use to user to give us a string
                Console.WriteLine(prompt);
                string answer = Console.ReadLine();
                string[] sentence = answer.Split(' ');

                foreach (var letter in sentence)
                {
                    
                    int countVowel = 0;
                    for (int i = 0; i < answer.Length; i++)
                    {
                        if (Regex.IsMatch(answer[i].ToString()))
                        {
                            countVowel = i + 1;
                        }
                        else
                        {
                            break;
                        }
                        Console.WriteLine("There are/is " + countVowel + " vowels.");
                    }
                }

                Console.WriteLine("\nCheck another line? y/n");

                string repeat = Console.ReadLine().ToLower();

                if (repeat == "y" || repeat == "yes")
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("Goodbye");
                    break;
                }

            }

        }
    }
}