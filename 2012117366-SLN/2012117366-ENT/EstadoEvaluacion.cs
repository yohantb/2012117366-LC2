using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
   public  class EstadoEvaluacion
    {
        public int EstadoEvaluacionid { get; set; }

        
        // Esto es para lo de infocorp  situacion

        public string Bancaria { get; set; }
        public static string siApto { get; private set; }
        public static string NoApto { get; private set; }

        string InfA = siApto;
        string InfB = NoApto;

        // si se encuentra infocorp o no
        public string Inforcorp(string Bancaria)
        {
            if (Bancaria == InfA)
            {
                return siApto;
            }
            else 
                return  NoApto;

            }







        }
    }
