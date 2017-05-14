using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
    public class TipoTrabajador : Trabajador
    {
        public int tipoTrabajadorid { get; set; }
        public int Empleado { get; set; }
        public TipoTrabajador()
            : base() { }



        public static string Cajero{ get; private set; }
        public static string Vendedor { get; private set; }
        public static string Gerente { get; private set; }
        string InfA = Cajero;
        string InfB = Vendedor;
        string InfC = Gerente;

        //  3 opciones de empleado
        public string TipoEmpleado (string Empleado)
        {
            if (Empleado == InfA)
            {
                return Cajero;
            }
            else if(Empleado == InfB)
            {
                return Vendedor;
            }
            return Gerente;

        }









    }
}
