using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
    public class Venta
    {
        public int VentaID { get; set; }

        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public TipoPago TipoPago { get; set; }

        public Contrato Contrato { get; set; }
        public int ContratoId { get; set; }

        public Evaluacion Evaluacion { get; set; }
        public int EvaluacionId { get; set; }

        public LineaTelefonica LineaTelefonica { get; set; }
        public int LineaTelefonicaId { get; set; }

        public CentroAtencion CentroAtencion { get; set; }
        public int CentroAtencionID { get; set; } 

    }
}
