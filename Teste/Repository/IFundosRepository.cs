﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Entities;

namespace Teste.Repository
{
    public interface IFundosRepository
    {
        List<Fundos> GetFundos();     

        
    }
}
