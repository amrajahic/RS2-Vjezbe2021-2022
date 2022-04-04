using AutoMapper;
using eProdaja.Services;
using eProdaja.Services.Database;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace eProdaja310322.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _korisniciService;

        public KorisniciController(IKorisniciService korisniciService)
        {
            _korisniciService = korisniciService;
        }

        [HttpGet]
        public IEnumerable<eProdaja.Models.Korisnici> Get()
        {
            return _korisniciService.Get();
        }

        
    }
}
