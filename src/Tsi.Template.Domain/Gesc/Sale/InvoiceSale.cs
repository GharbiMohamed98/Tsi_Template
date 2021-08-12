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
        public decimal AmountHT { get; set; } // not mapped
        public string Notes  { get; set; }
        public System.DateTime EntryDate { get; set; }
        public int CreationUserId { get; set; }
        public int ModifUserId { get; set; }
        public Customer Customer { get; set; }
    }
}
