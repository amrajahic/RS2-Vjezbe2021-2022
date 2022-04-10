using AutoMapper;
using eProdaja.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Database.Korisnici, Models.Korisnici>();
            CreateMap<Database.Proizvodi, Models.Proizvodi>();
            CreateMap<Database.JediniceMjere, Models.JediniceMjere>();
            CreateMap<Database.VrsteProizvodum, Models.VrsteProizvodum>();
            CreateMap<ProizvodiInsertRequest, Database.Proizvodi>();
            CreateMap<ProizvodiUpdateRequest, Database.Proizvodi>();



        }
    }
}
