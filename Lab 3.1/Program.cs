using System;

namespace Lab_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ввести строку : ");
            string str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'А' && str[i] <= 'Я') count++;
                else if (str[i] >= 'a' && str[i] <= 'z') str = str.Remove(i--, 1);
                else if (str[i] >= '0' && str[i] <= '9') str = str.Insert(i++, "+");
            }
            Console.WriteLine("\n результат : {0}\n кількість великих літер : {1}", str, count);
            Console.ReadKey(true);
        }
    }
}
    

