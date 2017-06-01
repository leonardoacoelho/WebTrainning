using OnBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTraining.DAL;

namespace WebTraining.BLL
{
    public class GrupoProdutoBO : BaseLogic<GrupoProduto, GrupoProdutoDAO>
    {
        public override void Save(GrupoProduto entity)
        {
            try
            {
                if (string.IsNullOrEmpty(entity.Descricao))
                    throw new ArgumentNullException("O campo descrição deve ser preenchido.");

                base.Save(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
