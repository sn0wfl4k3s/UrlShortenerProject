using System.Text;

namespace UrlShortener.Utility
{
    public class Converter
    {
        public static string DecToAnyBase(long Dec, long Base)
        {
            char[] chars =
                "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ@#$%&/*-+="
                .ToCharArray();

            if (Base < 2 || Base > chars.Length)
                return "";
            StringBuilder number = new StringBuilder();
            long rest;
            while (Dec > 0)
            {
                rest = Dec % Base;
                number.Append(chars[rest]);
                Dec /= Base;
            }
            return number.ToString();
        }
    }
}
