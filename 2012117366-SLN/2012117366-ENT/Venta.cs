using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
    public class Venta
    {
        public int ventaid { get; set; }
        public Venta() { }


        public class TipoPago
        {
            public TipoPago _TipoPago;


            public TipoPago (TipoPago tipoPagoid)
            {
                _TipoPago = tipoPagoid;


            }

            public TipoPago tipoPagoid { get { return _TipoPago; } }

        }

        public class Contrato
        {
            public Contrato _Contrato;


            public Contrato(Contrato  contratoid)
            {
                _Contrato = contratoid;


            }

            public Contrato contratoid { get { return _Contrato; } }

        }

        public class CentroAtencion
        {
            public CentroAtencion _CentroAtencion;


            public CentroAtencion(CentroAtencion centroatencionid)
            {
                _CentroAtencion = centroatencionid;


            }

            public CentroAtencion tipoPagoid { get { return _CentroAtencion; } }

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
