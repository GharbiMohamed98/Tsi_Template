using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsi.Template.Domain.Gesc.Sale;
using Tsi.Template.Infrastructure.Abstraction;

namespace Tsi.Template.Infrastructure.Configuration.Sale
{
   public class InvoiceSaleDetailConfigurations : EntityConfiguration<InvoiceSale>
    {
        public override void Configure(EntityTypeBuilder<InvoiceSale> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Number)
                .IsRequired();

            builder.Property(e => e.Date)
                .IsRequired();

            builder.Property(e => e.CustomerId)
                .IsRequired();

            builder.HasOne(s => s.Customer)
                 .WithMany(g => g.InvoiceSales)
                 .HasForeignKey(s => s.CustomerId);
        }
    }
}
