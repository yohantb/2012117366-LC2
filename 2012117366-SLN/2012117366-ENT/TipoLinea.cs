using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
   public  class TipoLinea : LineaTelefonica
    {
        public int Tipolineaid { get; set; }
        public int LineasOperador { get; set; }

        public TipoLinea()
            : base() { }



        public static string Prepago { get; private set; }
        public static string Postpago { get; private set; }
       
        string InfA = Prepago;
        string InfB = Postpago;


        //  2 opciones de Linea Prepago y postago 
        public string OperadorLinea(string LineasOperador)
        {
            if (LineasOperador == InfA)
            {
                return Prepago;
            }
            else
                return Postpago;

        }

    }










}

