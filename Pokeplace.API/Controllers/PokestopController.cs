using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pokeplace.Core;

namespace Pokeplace.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokestopController : ControllerBase
    {
        private readonly ILogger<PokestopController> _logger;

        public PokestopController(ILogger<PokestopController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]/listall")]
        public IEnumerable<Pokestop> ListAll()
        {
            return Pokestop.ListAll().ToList();
        }

        [HttpGet]
        [Route("[controller]/fetchbyid")]
        public Pokestop FetchById(int id)
        {
            return Pokestop.FetchById(id);
        }
    }
}
