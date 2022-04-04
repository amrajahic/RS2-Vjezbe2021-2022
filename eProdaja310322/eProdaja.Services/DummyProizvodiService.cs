using eProdaja.Services.Database;
using eProdaja.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class DummyProizvodiService : IProizvodiService
    {
      
        public DummyProizvodiService(eProdajaContext eProdajaContext)
        {
          
        }

        public List<Models.Proizvodi> ProizvodiList = new List<Models.Proizvodi>() { new Models.Proizvodi() { ProizvodId = 1, Naziv = "Laptop" },
        new Models.Proizvodi(){ ProizvodId = 2, Naziv = "Mobitel"} };
    
        public IEnumerable<Models.Proizvodi> Get()
        {
            ProizvodiList.Add(new Models.Proizvodi() { Naziv = "Test 1", ProizvodId = -1 });
            return ProizvodiList;
        }

       public Models.Proizvodi GetById(int Id)
        {
            return ProizvodiList.FirstOrDefault(x => x.ProizvodId == Id);
        }

    }
}
