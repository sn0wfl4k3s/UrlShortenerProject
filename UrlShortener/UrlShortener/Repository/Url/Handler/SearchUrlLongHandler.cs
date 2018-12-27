using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UrlShortener.Context;
using UrlShortener.Models;
using UrlShortener.Repository.Url.Request;

namespace UrlShortener.Repository.Url.Handler
{
    public class SearchUrlLongHandler : IRequestHandler<SearchUrlLongRequest, string>
    {
        private readonly AppDbContext _context;

        public SearchUrlLongHandler(AppDbContext context)
        {
            _context = context;
        }

        public Task<string> Handle(SearchUrlLongRequest request, CancellationToken cancellationToken)
        {
            URL url = _context.URLs
                .Where(u => u.UrlShort == request.UrlShort)
                .First();
            
            return Task.FromResult(url.UrlLong);
        }
    }
}
