namespace DataAccess
{
    using DataStructure;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SportsShopDBContext : DbContext
    {
        // Your context has been configured to use a 'SportsShopDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataAccess.SportsShopDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SportsShopDBContext' 
        // connection string in the application configuration file.
        public SportsShopDBContext()
            : base("name=SportsShopDBContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Citites { get; set; }
        public DbSet<Department> Departments  { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}