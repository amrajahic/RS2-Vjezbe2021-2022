using AutoMapper;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class BaseReadService<T, TSearch, TDb> : IReadService<T, TSearch> where T : class where TSearch : class where TDb : class
    {

    
    
        public eProdajaContext Context { get; set; }

        public IMapper Mapper { get; set; }
        public BaseReadService(eProdajaContext eProdajaContext, IMapper mapper)
        {
            Context = eProdajaContext;
            Mapper = mapper;
        }
        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var entity = Context.Set<TDb>();

            var list = entity.ToList();
            return Mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int Id)
        {
            var set = Context.Set<TDb>();
            var entity = set.Find(Id);
            return Mapper.Map<T>(entity);
        }
    }
}
