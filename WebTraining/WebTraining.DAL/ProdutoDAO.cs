using OnBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTraining.DAL.Context;
using System.Data.Entity;
using System.Linq.Expressions;

namespace WebTraining.DAL
{
    public class ProdutoDAO : BaseDataAccess<Produto>
    {
        public ProdutoDAO() : base(new DataContext())
        {

        }

        public override Produto Get(int id)
        {
            using (var context = new DataContext())
            {
                return context.Produtos.Include(x => x.GrupoProduto_Id).FirstOrDefault(x => x.Id == id);
            }
        }

        public override List<Produto> List()
        {
            using (var context = new DataContext())
            {
                return context.Produtos.Include(x => x.GrupoProduto_Id).ToList();
            }
        }

        public override List<Produto> List(Expression<Func<Produto, bool>> filter)
        {
            using (var context = new DataContext())
            {
                return context.Produtos.Include(x => x.GrupoProduto_Id).ToList();
            }
        }
    }
}
