using API_Project.Application.Interfaces.Repositories;
using API_Project.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Project.Persistance.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext dbContext;

        public WriteRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<int> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IList<int>> AddRangeAsync(IList<T> entity)
        {
            throw new NotImplementedException();
        }

        public Task HardDeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
