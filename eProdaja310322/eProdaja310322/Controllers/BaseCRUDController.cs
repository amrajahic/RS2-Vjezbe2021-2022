using eProdaja.Models.Requests;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja310322.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseReadController<T, TSearch> where T:class where TSearch:class where TInsert:class where TUpdate:class
    {

        protected readonly ICRUDService<T, TSearch, TInsert, TUpdate> _crudService;
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _crudService = service;
        }

        [HttpPost]

        public T Insert([FromBody] TInsert request)
        {
            return _crudService.Insert(request);
        }

        [HttpPut("{Id}")]

        public T Update(int Id, [FromBody] TUpdate request)
        {
            return _crudService.Update(Id, request);
        }
    }
}
