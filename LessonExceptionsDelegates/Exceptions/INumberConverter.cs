using System;
using System.Collections.Generic;
using System.Text;

namespace LessonExceptionsDelegates
{
    interface INumberConverter
    {
        string Convert(string @string);
        string Unconvert(string @string);
    }
}
