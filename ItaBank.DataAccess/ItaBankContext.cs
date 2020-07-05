﻿using ItaBank.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ItaBank.DataAccess
{
    public class ItaBankContext : DbContext
    {
        public ItaBankContext(DbContextOptions<ItaBankContext> options) : base(options)
        {
        }

        public DbSet<Account> AccountItems { get; set; }
    }
}