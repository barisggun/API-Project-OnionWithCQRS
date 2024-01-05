using API_Project.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Project.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : class, IEntityBase, new ()
    {
        Task<int> AddAsync(T entity);
        Task<IList<int>> AddRangeAsync(IList<T> entities);

        Task<T> UpdateAsync(T entity);

        Task HardDeleteAsync(T entity);
    }
}
