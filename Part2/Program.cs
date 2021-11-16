using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine().ToLower().Trim().Replace(" ","");
            int len = input.Length;

            bool palin = true;
            for (int i = 0; i < len; i++)
            {
                if (!input[i].Equals(input[len-1 - i])) {
                    palin = false;
                    break;
            }
            }

            Console.WriteLine("Предложение {0}палиндром", palin?"":"не ");
            Console.ReadKey();

        }
    }
}
