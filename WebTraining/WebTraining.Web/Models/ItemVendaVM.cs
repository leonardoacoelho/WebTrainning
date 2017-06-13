using WebTraining.Web.Models.Base;

namespace WebTraining.Web.Models
{
    public class ItemVendaVM : BaseVM
    {
        public int Item { get; set; }

        public Produto Produto { get; set; }

        public int Produto_Id { get; set; }

        public decimal Quantidade { get; set; }

        public decimal ValorUnitario { get; set; }

        public decimal ValoTotal { get; set; }

        public Venda Venda { get; set; }

        public int Venda_Id { get; set; }
    }
}