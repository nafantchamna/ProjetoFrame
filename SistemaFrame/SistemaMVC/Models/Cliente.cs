﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMVC.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
    }
}
