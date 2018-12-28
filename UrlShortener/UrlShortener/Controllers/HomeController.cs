using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UrlShortener.Repository.Url.Request;

namespace UrlShortener.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;
        private readonly InsertUrlRequest _insert;
        private readonly SearchUrlLongRequest _search;

        public HomeController(IMediator mediator, 
            InsertUrlRequest insert, 
            SearchUrlLongRequest search)
        {
            _mediator = mediator;
            _insert = insert;
            _search = search;
        }

        public IActionResult Index()   => View();
        public IActionResult About()   => View();
        public IActionResult Contact() => View();

         
        [HttpPost]
        public async Task<IActionResult> Cadastrar (string url)
        {
            _insert.UrlLong = url;
            string urlCod = await _mediator.Send(_insert);
            ViewData["url"] = $"https://{this.Request.Host}/url/{urlCod}";
            return View ("Result");
        }

        [HttpGet]
        [Route("url/{cod}")]
        public async Task<IActionResult> RedirectURL (string cod)
        {
            _search.UrlShort = cod;
            ViewData["url"] = await _mediator.Send(_search);
            return View ("Redirect");
        }
    }
}
