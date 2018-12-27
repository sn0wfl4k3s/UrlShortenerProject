using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortener.Repository.Url.Request
{
    public class SearchUrlLongRequest : IRequest<string>
    {
        public string UrlShort { get; set; }
    }
}
