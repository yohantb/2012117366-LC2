using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _2012117366_ENT;

namespace _2012117366_PER.EntityTypeConfigurations
{


    public class TipoPagoConfiguration : EntityTypeConfiguration<TipoPago>
    {
        public TipoPagoConfiguration()
        {
            ToTable("TipoPago");
            HasKey(a => a.TipoPagoID);

        }
    }
}

