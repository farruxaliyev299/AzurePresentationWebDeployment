using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AzurePresentationWebDeployment.Models;

public partial class AzurePresentationDbContext : DbContext
{
    public AzurePresentationDbContext(DbContextOptions<AzurePresentationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }
}
