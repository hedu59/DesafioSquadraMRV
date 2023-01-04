using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageConsumerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PresentationController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "API-SERVICE-MAIL"
        };

        private readonly ILogger<PresentationController> _logger;

        public PresentationController(ILogger<PresentationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Presentation> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Presentation
            {
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}