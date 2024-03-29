﻿using API_Project.Application.Interfaces.Repositories;
using API_Project.Application.Interfaces.UnitOfWorks;
using API_Project.Persistance.Context;
using API_Project.Persistance.Repositories;
using API_Project.Persistance.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Project.Persistance
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IReadRepository<>),typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>),typeof(WriteRepository<>));


            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        // IServiceCollection.AddPersistence() olarak çalışır.
    }
}
