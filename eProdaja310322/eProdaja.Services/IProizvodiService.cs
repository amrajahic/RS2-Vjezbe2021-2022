
using eProdaja.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IProizvodiService:IReadService<Proizvodi, ProizvodiSearchObject> /* interface koji ce biti odgovoran da dobavi proizvode */
    {
        
    }
}
