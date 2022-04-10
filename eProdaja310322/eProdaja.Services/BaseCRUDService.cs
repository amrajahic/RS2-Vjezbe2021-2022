using AutoMapper;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class BaseCRUDService<T, TSearch, TDb, TInsert, TUpdate>:BaseReadService<T, TSearch, TDb>, ICRUDService<T, TSearch, TInsert, TUpdate> where T:class where TSearch:class where TDb:class where TInsert:class where TUpdate:class
    {
      
        public BaseCRUDService(eProdajaContext eProdajaContext, IMapper mapper):base(eProdajaContext, mapper)
        {
            
        }

        public virtual T Insert(TInsert request)
        {
            var set = Context.Set<TDb>();

            TDb entity = Mapper.Map<TDb>(request);

            set.Add(entity);

            Context.SaveChanges();

            return Mapper.Map<T>(entity);
        }

        public virtual T Update(int Id, TUpdate request)
        {
            var set = Context.Set<TDb>();

            var entity = set.Find(Id);

            Mapper.Map(request, entity);

            Context.SaveChanges();

            return Mapper.Map<T>(entity);

        }

    }
}
