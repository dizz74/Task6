using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="жили были русский { китаец },  индус { немец { швед } } и американец {еще ктото}{и еще}{петя {маша{в маше мышка{в мышке яд}}}} на марсе";

            int pos;
            while ((pos = str.LastIndexOf('{')) != -1) {                
                str = str.Remove(pos, str.Substring(pos).IndexOf('}')+1);                
            }

            Console.WriteLine("Осталось:{0}",str);
            Console.ReadKey();
           

        }
    }
}
