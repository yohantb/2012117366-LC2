using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
    public class Plan
    {
            public int Planid { get; set; }

        public class TipoPlan 
        {
            public TipoPlan _TipoPlan;


            public TipoPlan (TipoPlan tipoPlanid)
            {
                _TipoPlan = tipoPlanid;


            }

            public TipoPlan tipoPlanid { get { return _TipoPlan; } }

        }

        public Plan() { }



    }
}
