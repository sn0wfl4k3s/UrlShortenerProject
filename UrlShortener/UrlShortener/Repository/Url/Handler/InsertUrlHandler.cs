using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UrlShortener.Context;
using UrlShortener.Models;
using UrlShortener.Repository.Url.Request;
using UrlShortener.Utility;

namespace UrlShortener.Repository.Url.Handler
{
    public class InsertUrlHandler : IRequestHandler<InsertUrlRequest, string>
    {
        private readonly AppDbContext _context;

        public InsertUrlHandler(AppDbContext context)
        {
            _context = context;
        }

        public Task<string> Handle(InsertUrlRequest request, CancellationToken cancellationToken)
        {
            long quant = _context.URLs.Count() + 1;
            string urlShort =  Converter.DecToAnyBase(quant, 62);

            URL url = new URL()
            {
                UrlShort = urlShort,
                UrlLong = request.UrlLong
            };

            _context.URLs.Add(url);
            _context.SaveChanges();

            return Task.FromResult(urlShort);
        }
    }
}
