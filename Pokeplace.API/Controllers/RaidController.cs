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
    public class RaidController : ControllerBase
    {
        private readonly ILogger<RaidController> _logger;

        public RaidController(ILogger<RaidController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]/listall")]
        public IEnumerable<Raid> ListAll()
        {
            return Raid.ListAll().ToList();
        }

        [HttpGet]
        [Route("[controller]/fetchbyid")]
        public Raid FetchById(int id)
        {
            return Raid.FetchById(id);
        }
    }
}
