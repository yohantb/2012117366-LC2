﻿using _2012117366_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_PER.EntitiesConfigurations
{
   public  class DistritoConfiguration : EntityTypeConfiguration<Distrito>
    {

        public DistritoConfiguration()
        {
            ToTable("Distrito");
            HasKey(a => a.DistritoID);

            HasRequired(a => a.Provincia)
                .WithMany(a => a.Distritos)
                .HasForeignKey(a => a.ProvinciaID);
        }






    }
}
