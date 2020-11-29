using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LessonExceptionsDelegates.Exceptions
{
    class ExceptionContext
    {
        public INumberConverter Converter { get; set; }
        public ExceptionContext()
        {
            Start();
        }

        private void Start()
        {
            while (true)
            {
                string typed;
                Console.WriteLine("Введите двоичное представление: ");
                typed = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(typed) || !typed.All(x => x == '0' || x == '1'))
                {
                    throw new NotBinaryException("долбаеб");
                }
                Console.WriteLine("1. 2 -> symbol");
                Console.WriteLine("2. 2 -> 16");
                Console.WriteLine("3. 2 -> 10");
                Console.WriteLine("Ответ: ");
                if (int.TryParse(Console.ReadLine(), out int answer))
                {
                    switch (answer)
                    {
                        case 1:
                        {
                            Converter = new BinaryToSymbol();
                            break;
                        }

                        case 2:
                        {
                            Converter = new BinaryToHEX();
                            break;
                        }

                        case 3:
                        {
                            Converter = new BinaryToDecimal();
                            break;
                        }
                    }

                    string result = Converter.Convert(typed);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
