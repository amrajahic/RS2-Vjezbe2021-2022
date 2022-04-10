using AutoMapper;
using eProdaja.Models;
using eProdaja.Services.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService: BaseCRUDService<Models.Proizvodi, Database.Proizvodi, Models.ProizvodiSearchObject, Models.Requests.ProizvodiInsertRequest, Models.Requests.ProizvodiUpdateRequest>, IProizvodiService
    {
      
        public ProizvodiService(eProdajaContext eProdajaContext, IMapper mapper)
            :base(eProdajaContext, mapper)
        {
           
        }

        public override IEnumerable<Models.Proizvodi> Get(ProizvodiSearchObject search = null)
        {
            var entity = Context.Set<Database.Proizvodi>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));   
            }

            if(search.JedinicaMjereId.HasValue)
            {
                entity = entity.Where(x=>x.JedinicaMjere.JedinicaMjereId == search.JedinicaMjereId.Value);

            }

            if (search.VrstaId.HasValue)
            {
                entity = entity.Where(x => x.Vrsta.VrstaId == search.VrstaId.Value);

            }

            if(search?.IncludeJedinicaMjere == true)
            {
                entity = entity.Include("JedinicaMjere");
            }

            if (search?.IncludeVrsta == true)
            {
                entity = entity.Include("JedinicaMjere");
            }

            if(search?.IncludeList.Length > 0)
            {
                foreach(var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();
            return Mapper.Map<List<Models.Proizvodi>>(list);
        }

        /*
        public override IEnumerable<Models.Proizvodi> Get()
        {
            return base.Get();
        }   
        
        public IEnumerable<Models.Proizvodi> GetByName(string name)
        {
            return base.Get().Where(x => x.Naziv.Contains(name)).ToList();
        }

        public IEnumerable<Models.Proizvodi> GetByVrstaId(int vrstaId)
        {
            return base.Get().Where(x => x.VrstaId == vrstaId).ToList();    
        }

        public IEnumerable<Models.Proizvodi> GetByVrstaIdAndNaziv(int vrstaId, string name)
        {
            return base.Get().Where(x => x.VrstaId == vrstaId && x.Naziv.Contains(name)).ToList();

        }
        */
    }
}
