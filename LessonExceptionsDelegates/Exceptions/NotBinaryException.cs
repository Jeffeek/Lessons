using System;

namespace LessonExceptionsDelegates
{
    public class NotBinaryException : Exception
    {
        private string _message = "Can't convert / Bad data";

        public override string Message => _message;

        public NotBinaryException(string message) : base(message)
        {
            _message = message;
        }

        public NotBinaryException() { }
    }
}
