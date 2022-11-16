using CIPMApplication2.Models;
using Microsoft.EntityFrameworkCore;

namespace CIPMApplication2.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options){ }
    public DbSet<Students> Students { get; set;  }
    public DbSet<Practitioners> Practitioners { get; set; }
}
