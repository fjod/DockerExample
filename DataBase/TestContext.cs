using System;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace DataBase
{
    public class TestContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Price> Prices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=db;port=3306;userid=dbuser;password=dbuserpassword;database=accountowner;",
                builder =>
                {
                    builder.ServerVersion(new Version(5, 6, 49), ServerType.MySql);
                    builder.CommandTimeout(30);
                    builder.EnableRetryOnFailure(5);
                });
        }
    }
}