﻿using Eduction.Core.Infrastructure;
using Eduction.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eduction.Data.Infrastructure
{
    public class DatabaseStartup : IApplicationStartup
    {
        public MiddleWarePriority Priority => MiddleWarePriority.AboveNormal;

        public void Configure(IApplicationBuilder app)
        {
            
        }

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
           
            services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
            services.AddDbContextPool<IApplcationDbContext, SqlServerApplicationContext>(
          c => c.UseSqlServer("Data Source=.;Initial Catalog=EductionDB;Integrated Security=true;")
      , poolSize: 16);
        }
    }
}
