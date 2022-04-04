
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IProizvodiService /* interface koji ce biti odgovoran da dobavi proizvode */
    {
        IEnumerable<Models.Proizvodi> Get();

        public Models.Proizvodi GetById(int Id);
    }
}
