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
    public class GymController : ControllerBase
    {
        private readonly ILogger<GymController> _logger;

        public GymController(ILogger<GymController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]/listall")]
        public IEnumerable<Gym> ListAll()
        {
            return Gym.ListAll().ToList();
        }

        [HttpGet]
        [Route("[controller]/fetchbyid")]
        public Gym FetchById(int id)
        {
            return Gym.FetchById(id);
        }
    }
}
