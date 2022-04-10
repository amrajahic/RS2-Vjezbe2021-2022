using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja310322.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseReadController<T, TSearch> : ControllerBase where T:class where TSearch : class
    {
       protected readonly IReadService<T, TSearch> _readService;

        public BaseReadController(IReadService<T, TSearch> service)
        {
            _readService = service;
        }
        
        [HttpGet]
        public virtual IEnumerable<T> Get([FromQuery]TSearch search)
        {
            return _readService.Get(search);
        }

        [HttpGet("{Id}")]

        public virtual T GetById(int Id)
        {
            return _readService.GetById(Id);
        }
    }
}
