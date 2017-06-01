using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebTraining.Web.Models.Base;

namespace WebTraining.Web.Models
{
    public class GrupoProdutoVM : BaseVM
    {
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}