using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebTraining.Web.Interface
{
    public interface IBaseController<TViewModel> where TViewModel : class
    {
        ActionResult Index();

        ActionResult Adicionar();

        [HttpPost]
        ActionResult Adicionar(TViewModel viewModel);

        ActionResult Editar(int? id);

        [HttpPost]
        ActionResult Editar(TViewModel viewModel);

        ActionResult Remover(int? id);

        [HttpPost]
        ActionResult Remover(int id);

        ActionResult Detalhar(int? id);
    }
}
