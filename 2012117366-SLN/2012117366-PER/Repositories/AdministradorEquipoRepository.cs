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
    public class AdministradorEquipoRepository : Repository<AdministradorEquipo>, IAdministradorEquipoRepository
    {
        private readonly TapiaDbContext _Context;

        public AdministradorEquipoRepository(TapiaDbContext context)
        {
            _Context = context;
        }

        private AdministradorEquipoRepository() { }

        IEnumerable<AdministradorEquipo> IAdministradorEquipoRepository.GetAdministradorEquipoWithEquipoCelular(int pageindex, int pageSize)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.add(AdministradorEquipo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.addRange(IEnumerable<AdministradorEquipo> entities)
        {
            throw new NotImplementedException();
        }

        AdministradorEquipo IRepository<AdministradorEquipo>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<AdministradorEquipo> IRepository<AdministradorEquipo>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<AdministradorEquipo> IRepository<AdministradorEquipo>.Find(System.Linq.Expressions.Expression<Func<AdministradorEquipo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.Update(AdministradorEquipo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.UpdateRange(IEnumerable<AdministradorEquipo> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.Delete(AdministradorEquipo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.DeleteRange(IEnumerable<AdministradorEquipo> entities)
        {
            throw new NotImplementedException();
        }
    }
}
