using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine();
            string[] words = input.Split();

            string maxWord="";            
            foreach (string word in words)
            {
                if (word.Length > maxWord.Length)  maxWord = word;             
            }


            Console.WriteLine("Самое длинное слово: "+maxWord);
            Console.ReadKey();


        }
    }
}
