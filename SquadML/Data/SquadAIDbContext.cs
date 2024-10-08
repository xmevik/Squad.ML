﻿using Microsoft.EntityFrameworkCore;
using Squad.ML.Application.Models;

namespace Squad.ML.Application.Data
{
    public class SquadAIDbContext : DbContext
    {
        public SquadAIDbContext(DbContextOptions<SquadAIDbContext> options) : base(options)
        {
        }

        public DbSet<AIPrep> AIPrep { get; set; }
    }
}
