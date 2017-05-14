using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
    public class AdministradorEquipo 
    {

        public int administradorEquid { get; set; }
        public string SistemaOperativo { get; set; }

        public static string Android { get; private set; }
        public static string Ios { get; private set; }
        public static string Windowsphone { get; private set; }
        string InfA = Android;
        string InfB = Ios;
        string InfC = Windowsphone;

        //  3 opciones de sistemas operativos
        public string Tiposistema(string Sistemaoperativo)
        {
            if (Sistemaoperativo == InfA)
            {
                return Android;
            }
            else if (Sistemaoperativo == InfB)
            {
                return Ios;
            }
            return Windowsphone;

        }










    }
}
