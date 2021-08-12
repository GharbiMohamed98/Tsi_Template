using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsi.Template.Core.Abstractions;

namespace Tsi.Template.Domain.Gesc.Sale
{
    public class Item : BaseEntity
    {
        public string References { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double VATRat { get; set; }
        public string Notes { get; set; }
        public DateTime EntryDate { get; set; }
        public bool Valid  { get; set; }
        public int CreationUserId { get; set; }
        public int ModifUserId { get; set; }


    }
}
