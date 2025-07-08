using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Student.Api.Data.Models;
using System.Reflection;

namespace Student.Api.Data.Context;

public class AppDbContext : DbContext
{
    public DbSet<Students> Students { get; set; }


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }



}



