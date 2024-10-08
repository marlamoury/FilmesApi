﻿using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data;

public class FilmeContext:DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> ops)
        : base(ops) 
    {
            
    }

    public DbSet<Filme> Filmes { get; set; }
}
