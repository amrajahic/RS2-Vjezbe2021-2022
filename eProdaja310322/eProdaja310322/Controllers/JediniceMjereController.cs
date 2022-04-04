using eProdaja.Models;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja310322.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JediniceMjereController : ControllerBase
    {
        private readonly IJediniceMjereService _jediniceMjereService;

        public JediniceMjereController(IJediniceMjereService jediniceMjereService)
        {
            _jediniceMjereService = jediniceMjereService;
        }

        [HttpGet]
        public IEnumerable<JediniceMjere> Get()
        {
            return _jediniceMjereService.Get();
        }

        [HttpGet("{Id}")]
        public JediniceMjere GetById(int Id)
        {
            return _jediniceMjereService.GetById(Id);
        }
    }
}
