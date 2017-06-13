using System;
using System.Collections.Generic;
using WebTraining.Web.Models.Base;

namespace WebTraining.Web.Models
{
    public class VendaVM : BaseVM
    {
        public Cliente Cliente { get; set; }

        public int Cliente_Id { get; set; }

        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

        public virtual List<ItemVenda> Itens { get; set; }
    }
}