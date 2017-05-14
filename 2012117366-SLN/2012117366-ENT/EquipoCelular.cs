using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
   public class EquipoCelular : AdministradorEquipo
    {
        public int EquipoCelularid{ get; set; }

        public string Modelo { get; set; }


        public EquipoCelular()
            : base() { }

        public static string Motorola { get; private set; }
        public static string Iphone { get; private set; }
        public static string Samsung { get; private set; }
        string InfA = Motorola;
        string InfB = Iphone;
        string InfC = Samsung;

        //  3 opciones de Equipos celular
        public string TipoModelo(string Modelo)
        {
            if (Modelo == InfA)
            {
                return Motorola;
            }
            else if (Modelo == InfB)
            {
                return Iphone;
            }
            return Samsung;

        }





    }
}
