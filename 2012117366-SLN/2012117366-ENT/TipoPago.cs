using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
   public  class TipoPago : Venta
    {
        public int tipopagoid { get; set; }
        public int PagoCliente { get; set; }

        public TipoPago()
            : base() { }


        public static string siEfectivo { get; private set; }
        public static string NoEfectivo { get; private set; }

        string InfA = siEfectivo;
        string InfB = NoEfectivo;

        //  Este metodo dira  efectivo o debito 
        public string Pago (string Pagocliente)
        {
            if (Pagocliente == InfA)
            {
                return siEfectivo;
            }
            else
                return NoEfectivo;

        }


    }
}
