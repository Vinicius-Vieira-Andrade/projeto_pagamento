using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pagamento
{
    public class Pagamento
    {
        public DateTime DataVencimento {get; private set;} = DateTime.Now.Date;

        public float Valor { get; set; }


        public string Cancelar()
        {
            return "Operação cancelada";
        }
    }
}