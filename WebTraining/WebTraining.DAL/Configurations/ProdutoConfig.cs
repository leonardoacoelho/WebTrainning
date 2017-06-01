using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTraining.DAL.Configurations
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            ToTable("Produtos");
            HasRequired(p => p.GrupoProduto)
                .WithMany(g => g.Produtos)
                .HasForeignKey(x => x.GrupoProduto_Id);
        }
    }
}
