using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc; 
using UrlShortener.Models;
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
            ViewData["url"] = await _mediator.Send(_insert);
            return View ("Result");
        }

        [HttpGet]
        [Route("url/{cod}")]
        public async Task<ActionResult> RedirectURL (string cod)
        {
            _search.UrlShort = cod;
            string url = await _mediator.Send(_search);
            if (url.StartsWith("http://"))
                return RedirectPermanent(url);
            return RedirectPermanent("http://" + url);
        }
    }
}
