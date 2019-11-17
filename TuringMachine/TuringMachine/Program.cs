using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;

namespace TuringMachine
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TextReader reader =
                new StreamReader(new FileStream(@"C:\Users\andris.zacs\Desktop\myInput.txt", FileMode.Open));
            string s = reader.ReadLine();
            string[] inp = s.Split(' ');
            Machine.TuringMachine machine = new Machine.TuringMachine(0, inp[0], inp[1], inp[2], reader.ReadToEnd());
            List<char> chars = machine.Run();
            Console.WriteLine(string.Join("", chars));
        }
    }
}