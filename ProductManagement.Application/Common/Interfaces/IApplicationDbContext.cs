﻿using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductManagement.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
