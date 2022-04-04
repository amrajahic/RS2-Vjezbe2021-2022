using AutoMapper;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService:IKorisniciService
    {
        // nasa klasa ce zavisiti od EntityFrameworka

        public eProdajaContext Context { get; set; }

        public IMapper Mapper { get; set; }
        public KorisniciService(eProdajaContext eProdajaContext, IMapper mapper)
        {
            Context = eProdajaContext;
            Mapper = mapper;
        }

        public IEnumerable<Models.Korisnici> Get()
        {
            List<Models.Korisnici> list = new List<Models.Korisnici>();

            var result = Context.Korisnicis.ToList();

          

            return Mapper.Map<List<Models.Korisnici>>(result);
        }


    }
}
