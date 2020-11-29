using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LessonExceptionsDelegates.Delegates
{
    public class DelegatesContext
    {
        public delegate string PrintSmile();
        public DelegatesContext()
        {
            PrintSmile smile = null;
            while (true)
            {
                Console.WriteLine("1. Веселый");
                Console.WriteLine("2. Задумчивый");
                Console.WriteLine("3. Грустный");
                if (int.TryParse(Console.ReadLine(), out int answer))
                {
                    switch (answer)
                    {
                        case 1:
                        {
                            smile = GetHappy;
                            break;
                        }
                        case 2:
                        {
                            smile = GetPensive;
                            break;
                        }
                        case 3:
                        {
                            smile = GetSad;
                            break;
                        }
                    }
                }
            }
        }

        private string GetHappy()
        {
            string happy = "**************\n" +
                           "*    |    |  *\n" +
                           "*   \\      / *\n" +
                           "*    ----    *\n" +
                           "*            *\n" +
                           "**************";
            Console.WriteLine(happy);
            return happy;
        }

        private string GetPensive()
        {
            string penis = "**************\n" +
                           "*   O    -   *\n" +
                           "*            *\n" +
                           "*    ---/    *\n" +
                           "*            *\n" +
                           "**************";
            Console.WriteLine(penis);
            return penis;
        }

        private string GetSad()
        {
            string sad =   "**************\n" +
                           "*   -    -   *\n" +
                           "*    ----    *\n" +
                           "*   /    \\  *\n" +
                           "*            *\n" +
                           "**************";
            Console.WriteLine(sad);
            return sad;
        }
    }
}
