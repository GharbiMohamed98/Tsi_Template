using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsi.Template.Core.Abstractions;
using Tsi.Template.Domain.Gesc.Catalog;

namespace Tsi.Template.Domain.Gesc.Sale
{
    public class InvoiceSaleDetails : BaseEntity
    {
        public int InvoiceSaleId { get; set; }
        public string ProductId { get; set; }
        public int Qte { get; set; }
        public decimal FinalePrice { get; set; }
        public double Discount { get; set; }
        public decimal Amount { get; set; } // not mapped
        public double Tax { get; set; }
        public Product Product { get; set; }
        public InvoiceSale InvoiceSale { get; set; }

    }
}
