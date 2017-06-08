﻿using _2012117366_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_PER.EntityTypeConfigurations
{

    public class LineaTelefonicaConfiguration : EntityTypeConfiguration<LineaTelefonica>
    {
        public LineaTelefonicaConfiguration()
        {
            ToTable("LineaTelefonica");
            HasKey(a => a.LineaTelefonicaID);

            HasRequired(a => a.AdministradorLinea)
                .WithMany(a => a.LineaTelefonica)
                .HasForeignKey(a => a.AdministradorLineaID);

            HasRequired(a => a.TipoLinea)
                .WithMany(a => a.LineaTelefonica);

        }
    }
}
