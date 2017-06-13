using OnBase;
using System;
using WebTraining.DAL;

namespace WebTraining.BLL
{
    public class ItemVendaBO : BaseLogic<ItemVenda, ItemVendaDAO>
    {
        public override void Save(ItemVenda entity)
        {
            try
            {
                Validar(entity);

                base.Save(entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void Validar(ItemVenda entity)
        {
            try
            {
                if (entity.Produto_Id <= 0 || entity.Quantidade <= 0 || entity.ValorUnitario <= 0)
                    throw new Exception("Preencha todos os campos corretamente.");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
