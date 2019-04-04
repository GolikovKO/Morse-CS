using System.Collections.Generic;

namespace ConsoleApp1
{
    class MorseDictionary
    {
        public static Dictionary<string, string> data;

        public static void init()
        {
            data = new Dictionary<string, string>();
            data.Clear();  

            data.Add("A", "*-");
            data.Add("B", "-***");
            data.Add("C", "-*-*");
            data.Add("D", "-**");
            data.Add("E", "*");
            data.Add("F", "**-*");
            data.Add("G", "--*");
            data.Add("H", "****");
            data.Add("I", "**");
            data.Add("J", "*---");
            data.Add("K", "-*-");
            data.Add("L", "*-**");
            data.Add("M", "--");
            data.Add("N", "-*");
            data.Add("O", "---");
            data.Add("P", "*--*");
            data.Add("Q", "--*-");
            data.Add("R", "*-*");
            data.Add("S", "***");
            data.Add("T", "-");
            data.Add("U", "**-");
            data.Add("V", "***-");
            data.Add("W", "*--");
            data.Add("X", "-**-");
            data.Add("Y", "-*--");
            data.Add("Z", "**--");

            data.Add("0", "-----");
            data.Add("1", "*----");
            data.Add("2", "**---");
            data.Add("3", "***--");
            data.Add("4", "****-");
            data.Add("5", "*****");
            data.Add("6", "-****");
            data.Add("7", "--***");
            data.Add("8", "---**");
            data.Add("9", "----*");

            data.Add("!", "--**--");
            data.Add("?", "**--**");
            data.Add("-", "=****-");
            data.Add(",", "*-*-*-");
            data.Add(";", "-*-*-*");

        }
    }
}
