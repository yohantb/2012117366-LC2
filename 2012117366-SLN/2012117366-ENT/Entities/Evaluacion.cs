﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
    public class Evaluacion
    {
        public int EvaluacionID { get; set; }

        public EstadoEvaluacion EstadoEvaluacion { get; set; }
        public int EstadoEvalucionId { get; set; }

        public TipoEvaluacion TipoEvaluacion { get; set; }


        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public Venta Venta { get; set; }
        public int VentaID { get; set; }


        public LineaTelefonica LineaTelefonica { get; set; }

        public EquipoCelular EquipoCelular { get; set; }

        public int plandId { get; set; }
        public Plan Plan { get; set; }

        public Trabajador Trabajador { get; set; }
        public int TrabajadorID { get; set; }


        public CentroAtencion CentroAtencion { get; set; }
        public int CentroAtencionID { get; set; }


    }
}
