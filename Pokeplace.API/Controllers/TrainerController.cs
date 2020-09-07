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
    //[Route("[controller]")]
    public class TrainerController : ControllerBase
    {
        private readonly ILogger<TrainerController> _logger;

        public TrainerController(ILogger<TrainerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]/listall")]
        public IEnumerable<Trainer> ListAll()
        {
            return Trainer.ListAll().ToList();
        }

        [HttpGet]
        [Route("[controller]/fetchbyid")]
        public Trainer FetchById(int id)
        {
            return Trainer.FetchById(id);
        }

        [HttpGet]
        [Route("[controller]/fetchbyapelido")]
        public Trainer FetchByApelido(string apelido)
        {
            return Trainer.FetchByApelido(apelido);
        }

        [HttpGet]
        [Route("[controller]/fetchbycodigo")]
        public Trainer FetchByCodigo(string codigo)
        {
            return Trainer.FetchByCodigo(codigo);
        }

        [HttpGet]
        [Route("[controller]/fetchconfig")]
        public TrainerConfig FetchConfig(int trainerId)
        {
            return TrainerConfig.FetchByTrainerId(trainerId);
        }
    }
}
