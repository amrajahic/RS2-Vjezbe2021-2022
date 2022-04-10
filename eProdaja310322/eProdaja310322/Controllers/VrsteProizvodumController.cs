using eProdaja.Models;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja310322.Controllers
{
//[ApiController]
  //  [Route("[controller]")]
    public class VrsteProizvodumController : BaseReadController<VrsteProizvodum, object>
    {
       

        public VrsteProizvodumController(IVrsteProizvodumService vrsteProizvodumService)
        :base(vrsteProizvodumService) {
        
        }

     
    }
}

