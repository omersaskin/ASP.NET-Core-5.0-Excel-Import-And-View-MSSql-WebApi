using WebApplication18.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace WebApplication18
{
    public class DBCtx : DbContext
    {
        public DBCtx(DbContextOptions<DBCtx> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}