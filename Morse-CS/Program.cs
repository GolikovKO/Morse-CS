using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {

            MorseDictionary.init();

            while (true)
            {
                Console.Write("Type your's sentence: ");

                string sentence;

                sentence = Console.ReadLine();

                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i] == ' ')
                    {
                        Thread.Sleep(70);
                        continue;
                    }

                    var z = MorseDictionary.data[sentence[i].ToString().ToUpper()];

                    Console.Write(z + " ");

                    for (int j = 0; j < z.Length; j++)
                    {
                        if (z[j] == '*')
                        {
                            Console.Beep(700, 100);
                        }
                        else
                        {
                            Console.Beep(700, 200);
                        }
                        Thread.Sleep(20);
                    }
                    Thread.Sleep(70);
                }
                Console.WriteLine();
            }
        }
    }
}
