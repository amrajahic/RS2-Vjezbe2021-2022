﻿using AutoMapper;
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


        }
    }
}
