using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebTraining.Web.Models.Base;

namespace WebTraining.Web.Models
{
    public class ClienteVM : BaseVM
    {
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}