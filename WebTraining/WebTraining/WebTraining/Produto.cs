using OnBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTraining
{
    public class Produto : Base
    {
        public string Descricao { get; set; }

        public double Valor { get; set; }

        public GrupoProduto GrupoProduto { get; set; }

        public int GrupoProduto_Id { get; set; }
    }
}
