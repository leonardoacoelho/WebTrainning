using AutoMapper;
using OnBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTraining.Web.Interface;

namespace WebTraining.Web.Controllers.Base
{
    public class BaseController<TEntity, TViewModel, TBO> : Controller, IBaseController<TViewModel>
    where TEntity : class
    where TViewModel : class
    where TBO : IBaseLogic<TEntity>, IDisposable, new()
    {
        public virtual ActionResult Index()
        {
            using (var bo = new TBO())
            {
                var entities = bo.List();

                var entitiesVm = Mapper.Map<List<TEntity>, List<TViewModel>>(entities);

                return View(entitiesVm);
            }
        }

        public virtual ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Adicionar(TViewModel viewModel) => PostViewModel(viewModel);

        public virtual ActionResult Editar(int? id)
        {
            var viewModel = GetViewModel(id);

            if (viewModel == null)
                return HttpNotFound();

            return View(viewModel);
        }

        [HttpPost]
        public virtual ActionResult Editar(TViewModel viewModel) => PostViewModel(viewModel);

        public virtual ActionResult Remover(int? id)
        {
            var viewModel = GetViewModel(id);

            if (viewModel == null)
                return HttpNotFound();

            return View(viewModel);
        }

        [HttpPost]
        public virtual ActionResult Remover(int id)
        {
            using (var bo = new TBO())
            {
                var entity = bo.Get(id);

                if (entity == null)
                    return HttpNotFound();

                bo.Remove(id);

                return RedirectToAction("Index");
            }
        }

        public virtual ActionResult Detalhar(int? id)
        {
            var viewModel = GetViewModel(id);

            if (viewModel == null)
                return HttpNotFound();

            return View(viewModel);
        }

        protected virtual TViewModel GetViewModel(int? id)
        {
            if (id == null)
                return null;

            using (var bo = new TBO())
            {
                var entity = bo.Get((int)id);

                if (entity == null)
                    return null;

                return Mapper.Map<TEntity, TViewModel>(entity);
            }
        }

        [HttpPost]
        protected virtual ActionResult PostViewModel(TViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    throw new Exception("O modelo não é válido");

                using (var bo = new TBO())
                {
                    var entity = Mapper.Map<TViewModel, TEntity>(viewModel);

                    bo.Save(entity);
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                PostViewModelError(viewModel);

                ModelState.AddModelError("", ex.Message);

                return View(viewModel);
            }
        }

        protected virtual void PostViewModelError(TViewModel viewModel)
        {

        }
    }
}