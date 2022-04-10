using eProdaja.Models;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja310322.Controllers
{
  //  [ApiController]
   // [Route("[controller]")]
    public class JediniceMjereController : BaseReadController<eProdaja.Models.JediniceMjere, object>
    {
   
        public JediniceMjereController(IJediniceMjereService jediniceMjereService)
            :base(jediniceMjereService)
        {
           
        }

      
    }
}
