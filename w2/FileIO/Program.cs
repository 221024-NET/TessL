using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main()
        {
            string path = "./testFile.txt";

            string[] text = {"hi","word2","것","that took more","effort than expected"};

            File.WriteAllLines(path, text);
            File.AppendAllLines(path, new string[] {"b","asf","asfobj"});
            File.AppendAllText(path, "bonki bibiss");
            File.AppendAllText(path, "bonki bibiss");
            foreach (string i in File.ReadAllLines(path)) { Console.WriteLine(i); }

        }
    }
}