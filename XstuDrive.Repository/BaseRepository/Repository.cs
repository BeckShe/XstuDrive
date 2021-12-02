using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XstuDrive.Repository.BaseRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public Task<bool> DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> QueryByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
