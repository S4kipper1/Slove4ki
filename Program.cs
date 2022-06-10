using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите 2 слова");
            List<string> goodWords = new List<string>() { "хороший", "молодец", "красавчик" };
            List<string> badWords = new List<string>() { "дурак", "тупой", "гад" };
            string resGood = "хорошие словечки, молодэц брат";
            string resBad = "ээээ если твая так гаварить, то я тебе жопа в рот пихать за такие словечки";
            string resNone = "нинаю такова, напишешь мб чего хорошего или плохого, ок?";
            string resBadAndGood = "не хорошо, но и не плохо";
            string a;
            List<string> words = new List<string>();
            result firstWord, secondWord;
            bool isInput;
            while (true)
            {
                words = new List<string>();
                a = Console.ReadLine();
                words = a.Split(' ').ToList();
                if (words.Count == 2)
                {
                    if (goodWords.Contains(words[0]))
                    {
                        firstWord = result.good;
                    }
                    else
                    {
                        if (badWords.Contains(words[0]))
                        {
                            firstWord = result.bad;
                        }
                        else
                        {
                            firstWord = result.none;
                        }
                    }
                    if (goodWords.Contains(words[1]))
                    {
                        secondWord = result.good;
                    }
                    else
                    {
                        if (badWords.Contains(words[1]))
                        {
                            secondWord = result.bad;
                        }
                        else
                        {
                            secondWord = result.none;
                        }
                    }

                    if (firstWord == result.good && secondWord == result.good)
                    {
                        Console.WriteLine(resGood);
                    }
                    if (firstWord == result.bad && secondWord == result.bad)
                    {
                        Console.WriteLine(resBad);
                    }
                    if ((firstWord == result.good && secondWord == result.bad) || (firstWord == result.bad && secondWord == result.good))
                    {
                        Console.WriteLine(resBadAndGood);
                    }
                    if (firstWord == result.none || secondWord == result.none)
                    {
                        Console.WriteLine(resNone);
                    }
                    Console.WriteLine("_____________________________");
                }
                else
                {
                    Console.WriteLine("ну саси епта блять если нихуя не можешь кампутер ебаный");
                }
            }
        }
    }
    enum result
    {
        good, bad, none
    }
}