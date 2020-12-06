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

            byte[] bin = File.ReadAllBytes(args[0]); // прочитать файл в массив байтов
            foreach(var b in bin) // проходимся по всем байтам
            {
                arr += "0x"; 
                arr += b.ToString("X") + ", ";
            }

            arr += "};";

            string fname = args[0] + ".c"; // будущее имя файла

            File.WriteAllText(fname, arr); // записываем результат в файл
            Console.WriteLine("OK! Создан массив из " + bin.Length.ToString() + " байт. Результат записан в файл " + fname);
        }
    }
}
