using System.ComponentModel.DataAnnotations;

namespace UrlShortener.Models
{
    public class URL
    {
        [Key]
        public long Id { get; set; }
        public string UrlShort { get; set; }
        public string UrlLong { get; set; }
    }
}
