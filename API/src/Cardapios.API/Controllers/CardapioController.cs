using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cardapios.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cardapios.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardapioController : ControllerBase
    {
    

        public IEnumerable<Cardapio> _cardapio = new Cardapio[] {
            new Cardapio() {
                CardapioId = 1,
                Nome = "Cardapio 1",
                Descricao = "Cardapio do restaurante 1 e 2",
                ImagemURL = "img.jpg",
                Prato = "Strogonoff"
            },
            new Cardapio() {
                CardapioId = 2,
                Nome = "Cardapio 2",
                Descricao = "Cardapio do restaurante 1 e 3",
                ImagemURL = "img2.jpg",
                Prato = "Strogonoff"
            }
        };
        public CardapioController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Cardapio> Get()
        {
            return _cardapio;
        }

        [HttpGet("{id}")]
        public IEnumerable<Cardapio> GetById(int id)
        {
            return _cardapio.Where( cardapio => cardapio.CardapioId == id);
        }

    }
}

