using OnBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTraining.DAL;

namespace WebTraining.BLL
{
    public class ClienteBO : BaseLogic<Cliente, ClienteDAO>
    {
        public override void Save(Cliente entity)
        {
            try
            {
                if (string.IsNullOrEmpty(entity.Nome))
                    throw new Exception("O campo nome deve ser preenchido");

                if (string.IsNullOrEmpty(entity.Email))
                    throw new Exception("O campo email deve ser preenchido");

                base.Save(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
