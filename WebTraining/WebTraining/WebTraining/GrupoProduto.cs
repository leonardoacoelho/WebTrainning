using OnBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTraining
{
    public class GrupoProduto : Base
    {
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
