using System;
using System.Collections.Generic;
using System.Text;

namespace LessonExceptionsDelegates
{
    public class BinaryToHEX : INumberConverter
    {
        public string Convert(string @string)
        {
            return System.Convert.ToUInt32(@string, 2).ToString("X");
        }

        public string Unconvert(string @string)
        {
            return "";
        }
    }
}
