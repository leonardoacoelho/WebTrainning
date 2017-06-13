using OnBase;
using System;
using System.Linq;
using WebTraining.DAL;

namespace WebTraining.BLL
{
    public class VendaBO : BaseLogic<Venda, VendaDAO>
    {
        public override void Save(Venda entity)
        {
            Validar(entity);

            base.Save(entity);
        }

        protected override void Insert(Venda entity)
        {
            //Fazer backup dos itens
            var itens = entity.Itens;

            //Anular os itens
            entity.Itens = null;

            //Inserir a venda
            base.Insert(entity);

            //Instanciar itemBO
            var itemBO = new ItemVendaBO();

            //Adicionar os itens
            foreach (var item in itens)
            {
                item.Venda_Id = entity.Id;
                itemBO.Save(item);
            }
        }

        protected override void Edit(Venda entity)
        {
            //Fazer backup dos itens
            var itens = entity.Itens;

            //Anular os itens
            entity.Itens = null;

            //Alterar a venda
            base.Edit(entity);

            //Obter itens mantidos
            var idsMantidos = itens.Where(x => x.Id > 0)
                                .Select(x => x.Id)
                                .ToList();

            //Instanciar itemBO
            var itemBO = new ItemVendaBO();

            //Encontrar os itens do banco
            var itensBD = itemBO.List().Where(x => x.Venda_Id == entity.Id);

            //Obter itens removidos
            var idsParaRemover = itensBD.Where(x => !idsMantidos.Contains(x.Id))
                                    .Select(x => x.Id)
                                    .ToList();

            //Remover os itens
            foreach (var id in idsParaRemover)
            {
                itemBO.Remove(id);
            }

            //Adicionar ou editar os itens
            foreach (var item in itens)
            {
                item.Venda_Id = entity.Id;
                itemBO.Save(item);
            }
    }

        public void Validar(Venda venda)
        {
            if (venda.Cliente_Id <= 0 || venda.Data == null)
                throw new Exception("Preencha todos os campos corretamente.");

            if ((venda.Itens?.Count ?? 0) == 0)
                throw new Exception("A venda deve conter intens.");
        }
    }
}
