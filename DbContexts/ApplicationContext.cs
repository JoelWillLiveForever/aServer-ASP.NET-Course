﻿using aServer_ASP.NET_Course.Models.Departments;
using aServer_ASP.NET_Course.Models.Employees;
using aServer_ASP.NET_Course.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace aServer_ASP.NET_Course.DbContexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null;
        public DbSet<Department> Departments { get; set; } = null;
        public DbSet<Employee> Employees { get; set; } = null;
        public DbSet<Education> Educations { get; set; } = null;
        public DbSet<WorkExperience> WorkExperience { get; set; } = null;

        public ApplicationContext() 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*base.OnConfiguring(optionsBuilder);*/
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=WebAPIDb;Username=postgres;Password=4607");
        }
    }
}