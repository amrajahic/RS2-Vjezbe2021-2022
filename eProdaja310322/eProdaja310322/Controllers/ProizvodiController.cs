using eProdaja.Models;
using eProdaja.Models.Requests;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja310322.Controllers
{
//    [ApiController]
 //   [Route("[controller]")]
    public class ProizvodiController : BaseCRUDController<eProdaja.Models.Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {

      

        public ProizvodiController(IProizvodiService proizvodiService)
            :base(proizvodiService)
        {
           
        }

        
    }
    
}
