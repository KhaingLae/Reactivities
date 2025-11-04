using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistance;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Activity> Activities { get; set; }

}
