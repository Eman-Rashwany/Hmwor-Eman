
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.SqlServer;

namespace HomWork_EF_Eman
{
    public  class ApplictionDbContext1:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder option) =>
            option.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=HomWork-EF-Eman;Integrated Security=True");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasOne(b => b.Sale)//الربط بين جدول السيارة والمبيعات هي one to one
                .WithOne(i => i.Car)
                .HasForeignKey<Sale>(b => b.CarId);

            modelBuilder.Entity<Car>()//الربط بين جدولي القطع والسيارة هي many to many
                .HasMany(c => c.Parts)
                .WithMany(p => p.Cars)
                .UsingEntity<CarParte>(
                   j => j
                       .HasOne(CP => CP.Part)
                       .WithMany(p => p.CarPartes)
                       .HasForeignKey(CP => CP.PartId),
                   j => j
                       .HasOne(CP => CP.Car)
                       .WithMany(c => c.CarPartes)
                       .HasForeignKey(CP => CP.CARId),
                   j =>
                   {  
                           j.Property(CP => CP.Addedon).HasDefaultValueSql("GETDATE()");
                           j.HasKey(t => new { t.CARId, t.PartId });
                   }
             );
            //modelBuilder.Entity<Suppliers>()//ربط بين جدولي المورد والقطع هي on to many
            // .HasMany(n => n.Parts)
            //.WithOne();
            modelBuilder.Entity<Part>()
                .HasOne(m => m.Suppliers)
                .WithMany(n => n.Parts);

             
        }
      
         public DbSet<Car>Cars { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Suppliers> suppliers { get; set; }
        public DbSet<Customer> Customer { get; set; }
        
        
    }
    
    
}
