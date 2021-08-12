using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsi.Template.Core.Abstractions;

namespace Tsi.Template.Domain.Gesc.Sale
{
    public class Customer : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public DateTime EntryDate { get; set; }
        public bool IsValid { get; set; }
        public int CreationUserId { get; set; }
        public ICollection<InvoiceSale> InvoiceSales { get; set; }
        
    }
}
