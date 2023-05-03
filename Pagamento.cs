namespace projeto_pagamento
{
    public class Pagamento
    {
        public DateTime DataVencimento {get; private set;} = DateTime.Now;

        public float Valor { get; set; }


        public string Cancelar()
        {
            return "Operação cancelada";
        }
    }
}