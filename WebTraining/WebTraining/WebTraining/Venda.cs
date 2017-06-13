using OnBase;
using System;
using System.Collections.Generic;

namespace WebTraining
{
    public class Venda : Base
    {
        public Cliente Cliente { get; set; }

        public int Cliente_Id { get; set; }

        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

        public virtual List<ItemVenda> Itens { get; set; }
    }
}
