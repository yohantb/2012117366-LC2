﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
    public class TipoPlan
    {
        public int TipoPlanID { get; set; }

        public ICollection<Plan> Plan { get; set; }



        public TipoPlan()
        {
            Plan = new Collection<Plan>();
        }
    }
}
