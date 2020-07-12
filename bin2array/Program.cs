using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bin2array
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = "byte bin[] = { ";

            byte[] bin = File.ReadAllBytes(args[0]);
            foreach(var b in bin)
            {
                arr += "0x";
                arr += b.ToString("X") + ", ";
                //Console.Write(b.ToString("X") + " ");
            }

            arr += "};";

            string fname = args[0] + ".c";

            File.WriteAllText(fname, arr);
            Console.WriteLine("OK! Создан массив из " + bin.Length.ToString() + " байт. Результат записан в файл " + fname);
        }
    }
}
