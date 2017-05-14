using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
    public class Evaluacion
    {

        public int evaluacionid { get; set; }
        public Evaluacion() { }

        public class EquipoCelular
        {
            public EquipoCelular _EquipoCelular;


            public EquipoCelular(EquipoCelular EquipoCelularid)
            {
                _EquipoCelular = EquipoCelularid;


            }

            public EquipoCelular EquipoCelularid { get { return _EquipoCelular; } }

        }
        public class EstadoEvaluacion
        {
            public EstadoEvaluacion _EstadoEvaluacion;


            public EstadoEvaluacion(EstadoEvaluacion EstadoEvaluacionid)
            {
                _EstadoEvaluacion = EstadoEvaluacionid;


            }

            public EstadoEvaluacion EstadoEvaluacionid { get { return _EstadoEvaluacion; } }

        }
        public class TipoEvaluacion
        {
            public TipoEvaluacion _TipoEvaluacion;


            public TipoEvaluacion(TipoEvaluacion tipoevaluacionid)
            {
                _TipoEvaluacion = tipoevaluacionid;


            }

            public TipoEvaluacion tipoevaluacionid { get { return _TipoEvaluacion; } }

        }

        int _Planid;
        public int Plan { get { return Planid; } }
        public int Planid
        {
            get
            {
                return _Planid;
            }

            set
            {
                _Planid = value;
            }
        }

        int _Clienteid;
        public int Cliente { get { return Clienteid; } }

        public int Clienteid
        {
            get
            {
                return _Clienteid;
            }

            set
            {
                _Clienteid = value;
            }
        }
    }
}
