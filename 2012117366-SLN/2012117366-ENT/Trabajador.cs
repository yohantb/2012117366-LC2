using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
    public class Trabajador
    {
        public int TrabajadorID { get; set; }

        public TipoTrabajador TipoTrabajador { get; set; }


        public ICollection<Evaluacion> Evaluacion { get; set; }
        public int EvaluacionID { get; set; }

    }
}
