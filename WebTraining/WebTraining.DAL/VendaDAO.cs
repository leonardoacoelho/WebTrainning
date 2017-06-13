using OnBase;
using WebTraining.DAL.Context;

namespace WebTraining.DAL
{
    public class VendaDAO : BaseDataAccess<Venda>
    {
        public VendaDAO() : base(new DataContext())
        {

        }
    }
}
