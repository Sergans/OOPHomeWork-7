using System;

namespace Lesson_7_1oop
{
    class Program
    {
        static void Main(string[] args)
        {    //Проверка
            ACoder a = new ACoder();
            BCoder c = new BCoder();
            string b = a.Encode("Шкаф");
            string z = c.Encode("Шкаф");
            Console.WriteLine(b);
            Console.WriteLine(a.Decode(b));
            Console.WriteLine(z);
            Console.WriteLine(c.Decode(z));
        }
    }
}
