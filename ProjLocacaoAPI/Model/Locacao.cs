﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjCarros.Model
{
    public class Locacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Carro Carro { get; set; }
    
    }
}
