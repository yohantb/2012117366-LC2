using _2012117366_ENT;
using _2012117366_PER.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_PER.Repositories
{
   public  class TipoEvaluacionRepository : Repository<TipoEvaluacion>,ITipoEvaluacionRepository
    {

        private readonly TapiaDbContext _Context;

        public TipoEvaluacionRepository(TapiaDbContext _Context)
        {
            // TODO: Complete member initialization
            this._Context = _Context;
        }

        private TipoEvaluacionRepository()
        {

        }




    }
}
