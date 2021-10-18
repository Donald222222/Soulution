using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductsApi.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Data
{
    public class SupplierDataContext : DbContext
    {
        public SupplierDataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Supplier> Supliers{ get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Supplier>().HasData(SeedData());
        //}
        //public List<Supplier> SeedData()
        //{
        //    var tests = new List<Supplier>();

        //    using (StreamReader r = new StreamReader(@"C:\Users\Donald\source\repos\CleaningSolution\ProductsApi\SeedData\Supplier DB.json"))
        //    {
        //        string json = r.ReadToEnd();
        //        tests = JsonConvert.DeserializeObject<List<Supplier>>(json);
        //    }
        //    return tests;
        //}
    }

}
