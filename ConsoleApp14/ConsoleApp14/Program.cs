using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Дано название футбольного клуба.Определить количество символов в нем.
            //Console.Write("Введите название футбольного клуба: ");
            //string name = Convert.ToString(Console.ReadLine());
            //int amount = 0;
            //for (int i = 0; i < name.Length; i++)
            //{
            //    amount++;
            //}
            //Console.WriteLine($"Количество символов в названии: {amount}");

            //Задача 2.Дано название города. Определить, четно или нет количество символов в нем.
            //Console.Write("Введите название города: ");
            //string name = Convert.ToString(Console.ReadLine());
            //int amount = 0;
            //for (int i = 0; i < name.Length; i++)
            //{
            //    amount++;
            //}
            //if (amount % 2 == 0)
            //{ Console.WriteLine("Количество символов в названии чётное"); }
            //else { Console.WriteLine("Количество символов в названии нечётное"); }

            //Задача 3.Даны две фамилии. Определить, какая из них длиннее.
            //Console.Write("Введите фамилию: ");
            //string name1 = Convert.ToString(Console.ReadLine());
            //Console.Write("Введите вторую фамилию: ");
            //string name2 = Convert.ToString(Console.ReadLine());
            //if (name1.Length > name2.Length)
            //{ Console.WriteLine("Первая фамилия длиннее второй"); }
            //else if (name1.Length < name2.Length)
            //{ Console.WriteLine("Вторая фамилия длиннее первой"); }
            //else { Console.WriteLine("Фамилии одинаковые по длине"); }

            //Задача 4.Найти самое длинное слово из пяти введенных с клавиатуры.
            //string st = "";
            //int L = st.Length;
            //string s = "";
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"введ {i + 1} ");
            //    string st1 = Console.ReadLine();
            //    if (st1.Length > L)
            //    {
            //        L = st1.Length;
            //        s = st1;
            //    }
            //}
            //Console.WriteLine($"самое длинное слово {s} имеет{L}");

            //Задача 5.Составить программу, которая запрашивает отдельно имя и отдельно фамилию, а затем выводит их как одну символьную строку.
            //Console.WriteLine("Введите имя:");
            //string first_name = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Введите фамилию:");
            //string last_name = Convert.ToString(Console.ReadLine());
            //Console.WriteLine($"{first_name}{last_name}");

            //Задача 6.Подсчитать количество букв "а"("А") в строке.
            //Console.Write("Введите слово: ");
            //string word = Convert.ToString(Console.ReadLine());
            //int count = 0;
            //foreach (char a in word)
            //{
            //    if (a == 'а')
            //    { count++; }
            //    if (a == 'А')
            //    { count++; }
            //}
            //Console.WriteLine(count);

            //Задача 7.Подсчитать количество слов в предложении, при условии, что каждое слово отделяется от другого пробелом.
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string[] words = str.Split(" ".ToCharArray());
            for (int i = 0; i < words.Length; i++)
            { }
            Console.WriteLine($"Количество слов в строке:{words.Length} ");
            Console.ReadKey();
        }
    }
}
