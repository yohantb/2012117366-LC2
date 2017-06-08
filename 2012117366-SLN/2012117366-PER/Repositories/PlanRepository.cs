using _2012117366_ENT;
using _2012117366_PER.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_PER.Repositories
{
    class PlanRepository : Repository<Plan>, IPlanRepository
    {
        private TapiaDbContext _Context;

        public PlanRepository(TapiaDbContext _Context)
        {
            // TODO: Complete member initialization
            this._Context = _Context;
        }

        private PlanRepository()
        {

        }
    }
}
