using _2012117366_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_PER.EntityTypeConfigurations
{
    public class ProvinciaConfiguration : EntityTypeConfiguration<Provincia>
    {
        public ProvinciaConfiguration()
        {
            ToTable("Provincia");
            HasKey(a => a.ProvinciaID);

            HasRequired(a => a.Departamento)
                .WithMany(a => a.Provincia)
                .HasForeignKey(a => a.DepartamentoID);
        }
    }
}
