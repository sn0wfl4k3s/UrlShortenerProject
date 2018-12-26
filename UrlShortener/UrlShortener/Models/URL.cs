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
    }
}
