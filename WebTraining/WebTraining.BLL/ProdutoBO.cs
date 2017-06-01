using OnBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTraining.DAL;

namespace WebTraining.BLL
{
    public class ProdutoBO : BaseLogic<Produto, ProdutoDAO>
    {
        public override void Save(Produto entity)
        {
            try
            {
                if (string.IsNullOrEmpty(entity.Descricao))
                    throw new ArgumentNullException("O campo descrição é obrigatório.");

                if (entity.Valor <= 0)
                    throw new ArgumentNullException("O campo valor deve ser maior que 0 (zero).");

                if(entity.GrupoProduto_Id == null)
                    throw new ArgumentNullException("O grupo do produto deve ser escolhido.");

                base.Save(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
