using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTraining.BLL;
using WebTraining.Web.Controllers.Base;
using WebTraining.Web.Models;
using OnBase;
using WebTraining.Web.Utils;

namespace WebTraining.Web.Controllers
{
    public class ProdutoController : BaseController<Produto, ProdutoVM, ProdutoBO>
    {
        public override ActionResult Adicionar()
        {
            var produtoVm = new ProdutoVM
            {
                GruposProdutos = PreencherGrupos()
            };
            return View(produtoVm);
        }

        protected override void PostViewModelError(ProdutoVM viewModel)
        {
            viewModel.GruposProdutos = PreencherGrupos();
        }

        public SelectList PreencherGrupos()
        {
            using (var bo = new GrupoProdutoBO())
            {
                var grupos = bo.List();
                return grupos.Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString() }).ToSelectList();
            }
        }
    }
}