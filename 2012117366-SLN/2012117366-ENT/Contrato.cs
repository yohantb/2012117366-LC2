using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
   public  class Contrato : Venta
    {
        public int contratoid{ get; set; }
        public int tiempoContrato { get; set; }

      


        // 12 meses o 18 meses
        public static string sidocemeses { get; private set; }
        public static string Nodocemeses { get; private set; }

        string InfA = sidocemeses;
        string InfB = Nodocemeses;

        //  Este metodo dira  efectivo o debito 

        public string MetodoContrato(string tiempoContrato)
        {
            if (tiempoContrato == InfA)
            {
                return sidocemeses;
            }
            else
                return Nodocemeses;

        }





    }

    
}
