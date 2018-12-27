using MediatR;

namespace UrlShortener.Repository.Url.Request
{
    public class InsertUrlRequest : IRequest<string>
    {
        public string UrlLong { get; set; }
    }
}
