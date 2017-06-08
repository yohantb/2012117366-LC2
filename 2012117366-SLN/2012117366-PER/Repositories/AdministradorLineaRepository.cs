using _2012117366_ENT;
using _2012117366_PER.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_PER.Repositories
{
    class AdministradorLineaRepository : Repository<AdministradorLinea>, IAdministradorLineaRepository
    {
        private TapiaDbContext _Context;

        public AdministradorLineaRepository(TapiaDbContext _Context)
        {
            // TODO: Complete member initialization
            this._Context = _Context;
        }

        private AdministradorLineaRepository()
        {

        }
    }
}
