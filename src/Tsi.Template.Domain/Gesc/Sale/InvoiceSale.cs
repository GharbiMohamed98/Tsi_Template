using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsi.Template.Core.Abstractions;

namespace Tsi.Template.Domain.Gesc.Sale
{
    public class InvoiceSale : BaseEntity
    {
        public int Number { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Amount { get; set; } // not mapped
        public Customer Customer { get; set; }
    }
}
