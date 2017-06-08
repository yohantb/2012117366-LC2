using _2012117366_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_PER.EntityTypeConfigurations
{

    public class EquipoCelularConfiguration : EntityTypeConfiguration<EquipoCelular>
    {
        public EquipoCelularConfiguration()
        {
            ToTable("EquipoCelular");
            HasKey(a => a.EquipoCelularID);

            HasRequired(a => a.AdministradorEquipo)
                .WithMany(e => e.EquipoCelular)
                .HasForeignKey(a => a.AdministradorEquipoID);


        }
    }
}
