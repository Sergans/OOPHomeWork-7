using System;

namespace Lesson_7_1oop
{
    class Program
    {
        static void Main(string[] args)
        {
            ACoder a = new ACoder();
            string b = a.Encode("Шкаф");
            Console.WriteLine(b);
            Console.WriteLine(a.Decode(b));
        }
    }
}
