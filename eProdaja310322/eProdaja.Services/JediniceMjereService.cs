﻿using AutoMapper;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class JediniceMjereService:BaseReadService<Models.JediniceMjere, Database.JediniceMjere, object>, IJediniceMjereService
    {
      
        public JediniceMjereService(eProdajaContext eProdajaContext, IMapper mapper)
        :base(eProdajaContext, mapper)
        {
           
        }

      
    }
}
