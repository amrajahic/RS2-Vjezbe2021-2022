using AutoMapper;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class VrsteProizvodumService:BaseReadService<Models.VrsteProizvodum, Database.VrsteProizvodum, object>, IVrsteProizvodumService
    {
       
        public VrsteProizvodumService(eProdajaContext eProdajaContext, IMapper mapper)
        :base(eProdajaContext, mapper)
        {
            
        }

      
    }
}

