using AutoMapper;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class JediniceMjereService:IJediniceMjereService
    {
        public eProdajaContext Context { get; set; }

        public IMapper Mapper { get; set; }
        public JediniceMjereService(eProdajaContext eProdajaContext, IMapper mapper)
        {
            Context = eProdajaContext;
            Mapper = mapper;
        }

        public IEnumerable<Models.JediniceMjere> Get()
        {


            var result = Context.JediniceMjeres.ToList();



            return Mapper.Map<List<Models.JediniceMjere>>(result);
        }

        public Models.JediniceMjere GetById(int Id)
        {
            var result = Context.JediniceMjeres.Find(Id);

            return Mapper.Map<Models.JediniceMjere>(result);
        }
    }
}
