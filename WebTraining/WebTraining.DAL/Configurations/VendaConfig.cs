using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTraining.DAL.Configurations
{
    public class VendaConfig : EntityTypeConfiguration<Venda>
    {
        public VendaConfig()
        {
            ToTable("Vendas");

            HasRequired(v => v.Cliente)
                .WithMany()
                .HasForeignKey(x => x.Cliente_Id);
        }
    }
}
