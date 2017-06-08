using OnBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTraining.DAL.Context;

namespace WebTraining.DAL
{
    public class ClienteDAO : BaseDataAccess<Cliente>
    {
        public ClienteDAO() : base(new DataContext())
        {

        }
    }
}
