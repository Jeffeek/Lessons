namespace LessonExceptionsDelegates
{
    class BinaryToSymbol : INumberConverter
    {
        public string Convert(string @string)
        {
            var converter = new BinaryToDecimal();
            var stringDecimal = converter.Convert(@string);
            return ((char)int.Parse(stringDecimal)).ToString();
        }

        public string Unconvert(string @string)
        {
            return "";
        }
    }
}
