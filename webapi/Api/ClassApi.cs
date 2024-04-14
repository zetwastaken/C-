using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;


namespace Api
{

    public class Vies
    {
        [Key]
        public required string vatNumber { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public override string ToString()
        {
            return $"{name}, {vatNumber}";
        }
        public string ToStringAll()
        {
            return $"{name}, {vatNumber}, {address}";
        }   
    }


    public class ViesAll : DbContext
    {
        public DbSet<Vies> viesAll { get; set; }
        public ViesAll()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Univ5.db");

        }



    }
}
