using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
    public class TipoEvaluacion
    {
        public int tipoevaluacionid { get; set; }

        // DNI MAYOR DE 18 Ejem todo dni superiror al 70125292 son mayores de 18
        public int Dni { get; set; }

      // 1 y 2 vendrian ser APTO O NO .
        public double  MayoriaDeEdad (int Edad) {
            if(Dni>70125292){
                return 1;
            } else {
                return 2;

            }

         




        }

        



        

   



    }
}
