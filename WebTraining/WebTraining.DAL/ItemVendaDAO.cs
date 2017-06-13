using OnBase;
using WebTraining.DAL.Context;

namespace WebTraining.DAL
{
    public class ItemVendaDAO : BaseDataAccess<ItemVenda>
    {
        public ItemVendaDAO() : base(new DataContext())
        {

        }
    }
}
