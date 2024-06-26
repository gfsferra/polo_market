﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Areas.Identity.Data;

namespace WebApplication1.Data;

public class WebApplication1Context : IdentityDbContext<UsuarioModel>
{
    public WebApplication1Context(DbContextOptions<WebApplication1Context> options)
        : base(options)
    {
    }

    public DbSet<WebApplication1.Models.Prato> Prato { get; set; }

    public DbSet<WebApplication1.Models.Categoria> Categoria { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
