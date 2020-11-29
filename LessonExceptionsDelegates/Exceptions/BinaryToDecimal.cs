namespace LessonExceptionsDelegates
{
    public class BinaryToDecimal : INumberConverter
    {
        public string Convert(string @string)
        {
            return System.Convert.ToInt32(@string, 2).ToString();
        }

        public string Unconvert(string @string)
        {
            return "";
        }
    }
}
