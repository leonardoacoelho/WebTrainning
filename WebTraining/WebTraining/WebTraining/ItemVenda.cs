using OnBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTraining
{
    public class ItemVenda : Base
    {
        public int Item { get; set; }

        public Produto Produto { get; set; }

        public int Produto_Id { get; set; }

        public decimal Quantidade { get; set; }

        public decimal ValorUnitario { get; set; }

        public decimal ValoTotal { get; set; }

        public Venda Venda { get; set; }

        public int Venda_Id { get; set; }   
    }
}
