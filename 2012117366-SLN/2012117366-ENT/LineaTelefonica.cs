using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
  public   class LineaTelefonica : AdministradorLinea
    {
        public int Lineatelfonicaid { get; set; }
        public string Operadores { get; set; }


        public LineaTelefonica()
            : base() { }





        public static string Movistar { get; private set; }
        public static string Claro { get; private set; }
        public static string Entel { get; private set; }
        string InfA = Movistar;
        string InfB = Claro;
        string InfC = Entel;

        //  3 opciones de empleado
        public string TipoLinOperador(string Operadores)
        {
            if (Operadores == InfA)
            {
                return Movistar;
            }
            else if (Operadores == InfB)
            {
                return Claro;
            }
            return Entel;

        }






    }
}
