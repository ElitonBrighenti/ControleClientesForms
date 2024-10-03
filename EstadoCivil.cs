﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    public enum EstadoCivil
    {
        Solteiro,
        Casado,
        Divorciado,
        Viuvo
    }

    public class ItemEstadoCivil
    {
        public EstadoCivil Valor { get; set; }
        public string Descricao { get; set; }
    }
}