using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XstuDrive.Repository.BaseRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> InsertAsync(TEntity entity);
        Task<bool> DeleteAsync(TEntity entity);
        Task<bool> DeleteByIdAsync(Guid id);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> QueryByIdAsync(Guid id);
    }
}
