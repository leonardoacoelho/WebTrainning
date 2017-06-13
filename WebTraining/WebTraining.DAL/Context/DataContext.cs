using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTraining.DAL.Configurations;

namespace WebTraining.DAL.Context
{
    public class DataContext : DbContext
    {
        public DataContext() 
            : base("name=DataContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ProdutoConfig());
            modelBuilder.Configurations.Add(new GrupoProdutoConfig());
            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new VendaConfig());
            modelBuilder.Configurations.Add(new ItemVendaConfig());
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<GrupoProduto> GrupoProdutos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemVenda> ItensVendas { get; set; }
    }
}
