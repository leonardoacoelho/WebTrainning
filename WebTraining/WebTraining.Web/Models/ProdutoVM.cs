using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTraining.Web.Models.Base;

namespace WebTraining.Web.Models
{
    public class ProdutoVM : BaseVM
    {
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Valor")]
        public double Valor { get; set; }

        public GrupoProduto GrupoProduto { get; set; }

        [Display(Name = "Grupo de Produto")]
        public int GrupoProduto_Id { get; set; }

        public SelectList GruposProdutos { get; set; }
    }
}