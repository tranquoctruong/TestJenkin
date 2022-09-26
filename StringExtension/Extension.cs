namespace StringExtension
{
    public static class Extension
    {
        public static int ToNumber (this string value)
        {
            return int.Parse(value);
        }
    }
}