using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
   public  class Trabajador
    {
        public int trabajadorid { get; set; }

        public class TipoTrabajador
        {
            public TipoTrabajador _TipoTrabajador;


            public TipoTrabajador(TipoTrabajador tipoTrabajadorid)
            {
                _TipoTrabajador = tipoTrabajadorid;


            }

            public TipoTrabajador tipoTrabajadorid { get { return _TipoTrabajador; } }

        }

        public Trabajador() { }







    }
}
