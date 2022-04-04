using AutoMapper;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService:IProizvodiService
    {
        public eProdajaContext Context { get; set; }

        public IMapper Mapper { get; set; }
        public ProizvodiService(eProdajaContext eProdajaContext, IMapper mapper)
        {
            Context = eProdajaContext;
            Mapper = mapper;
        }

        public IEnumerable<Models.Proizvodi> Get()
        {
            

            var result = Context.Proizvodis.ToList();



            return Mapper.Map<List<Models.Proizvodi>>(result);
        }

        public Models.Proizvodi GetById(int Id)
        {
            var result = Context.Proizvodis.Find(Id);

            return Mapper.Map<Models.Proizvodi>(result);
        }
    }
}
