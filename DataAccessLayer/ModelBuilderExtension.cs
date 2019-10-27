using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
            new Customer() { Id = 1, Name = "Thus", Email = "thus@gmail.com", Gender = "M", DateRegistered = Convert.ToDateTime("01/Aug/2019"), Day1 = false, Day2 = false, Day3 = true, AdditionalRequest = "Act" },
            new Customer() { Id = 2, Name = "Ram", Email = "ram@gmail.com", Gender = "M", DateRegistered = Convert.ToDateTime("01/Aug/2019"), Day1 = true, Day2 = true, Day3 = false, AdditionalRequest = "Act" }
            );
        }
    }
}
