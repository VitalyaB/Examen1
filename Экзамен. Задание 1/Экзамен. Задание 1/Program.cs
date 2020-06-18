using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Экзамен.Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива - ");
            int a = int.Parse(Console.ReadLine());
            int[] array = new int[a];
            Random r = new Random();
            FileStream file1 = new FileStream("test.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(15);
                writer.WriteLine(array[i]);
            }
            writer.Close();
            Console.WriteLine("Запись прошла успешно");
            FileStream file2 = new FileStream("test.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file2);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            Console.ReadKey();
        }
    }
}
