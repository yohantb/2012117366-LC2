using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
    public class TipoPlan : Plan 
    {

        public int tipoPlanid { get; set; }
        public string NamePlan { get; set; }

        public string NumeroPlan { get; set; }



        public TipoPlan()
            : base() { }


        int a = 90;
        int b = 60;


        public double Tarifa(int NamePlan)
        {

            if (NamePlan == a)
            {
                return 89.9;
            }
            if (NamePlan == b)
            {
                return 59.9;
            }
            else return 29.9;
        }



        

    }
}
