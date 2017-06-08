using _2012117366_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_PER.EntityTypeConfigurations
{

    public class TipoTrabajadorConfiguration : EntityTypeConfiguration<TipoTrabajador>
    {
        public TipoTrabajadorConfiguration()
        {
            ToTable("TipoTrabajador");
            HasKey(a => a.TipoTrabajadorID);

        }
    }
    
}
