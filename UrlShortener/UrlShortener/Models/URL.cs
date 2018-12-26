using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortener.Models
{
    public class URL
    {
        public int Id { get; set; }
        public string UrlShort { get; set; }
        public string UrlLong { get; set; }

        public URL (string urlLong)
        {
            UrlLong = urlLong;
        }

        private string DecToHex (int num)
        {
            return Convert.ToString(num, 16);
        }
        private int HexToDec (string hex)
        {
            return int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        }
    }
}
