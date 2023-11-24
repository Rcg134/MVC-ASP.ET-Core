using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MVC_ASP.ET_Core.Models;

namespace MVC_ASP.ET_Core.Context;

public partial class EmployeeContext : DbContext
{

    private IConfiguration _configuration;
    public EmployeeContext()
    {
    }

    public EmployeeContext(DbContextOptions<EmployeeContext> options , IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    //Add your Table Class here ...
    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<Files> File { get; set; }
    public virtual DbSet<JobTitle> JobTitle { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:DefaultConnection"]);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
