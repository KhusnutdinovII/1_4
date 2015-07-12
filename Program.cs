using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1, word2;
            int count = 0;

            Console.Write("Введите первое слово: ");
            word1 = Console.ReadLine();
            word1.ToLower();
            word1.Trim();

            Console.Write("Введите второе слово: ");
            word2 = Console.ReadLine();
            word2.ToLower();
            word2.Trim();

            for (int i = 0; i < word2.Length; i++) //Смотрим каждую букву во втором слове
            {
                if (word1.Contains(word2[i])) //Если она содержится в первом слове
                {
                    count++; //то увеличиваем счетчик
                }
            }

            if (count == word2.Length) //Если значение счетчика равно длине второго слова
            {
                Console.Write("Можно."); //значит нужные буквы есть
            }
            else
            {
                Console.Write("Нельзя."); //иначе нужных букв не хватает
            }
            Console.ReadKey();
        }
    }
}

