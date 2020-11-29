using System;
using System.Text;
using LessonExceptionsDelegates.Delegates;
using LessonExceptionsDelegates.Exceptions;

namespace LessonExceptionsDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Выберите стратегию 0 - ex, 1 - del: ");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 0)
            {
                var obj = new ExceptionContext();
            }
            else
            {
                var obj = new DelegatesContext();
            }

            Console.ReadLine();
        }
    }
}
