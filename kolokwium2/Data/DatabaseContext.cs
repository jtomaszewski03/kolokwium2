using kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium2.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Models.Program> Programs { get; set; }
    public DbSet<AvailableProgram> AvailablePrograms { get; set; }
    public DbSet<PurchaseHistory> PurchaseHistories { get; set; }
    public DbSet<WashingMachine> WashingMachines { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Customer>().HasData(new List<Customer>()
        {
            new Customer() { CustomerId = 1, FirstName = "John", LastName = "Doe", PhoneNumber = "123456"},
            new Customer() { CustomerId = 2, FirstName = "Jane", LastName = "Morgan", PhoneNumber = "23124142"},
        });
        
        modelBuilder.Entity<Models.Program>().HasData(new List<Models.Program>()
        {
            new Models.Program() { ProgramId = 1, Name = "Washing Fast", DurationMinutes = 60, TemperatureCelsius = 30},
            new Models.Program() { ProgramId = 2, Name = "Washing Slow", DurationMinutes = 120, TemperatureCelsius = 40}
        });
        
        modelBuilder.Entity<AvailableProgram>().HasData(new List<AvailableProgram>()
        {
            new AvailableProgram() { AvailableProgramId = 1, WashingMachineId = 1, ProgramId = 1, Price = 30},
            new AvailableProgram() { AvailableProgramId = 2, WashingMachineId = 2, ProgramId = 2, Price = 60}
        });
        
        modelBuilder.Entity<WashingMachine>().HasData(new List<WashingMachine>()
        {
            new WashingMachine() { WashingMachineId = 1, MaxWeight = 50, SerialNumber = "SN252152"},
            new WashingMachine() { WashingMachineId = 2, MaxWeight = 100, SerialNumber = "SN999152"}
        });
        
        modelBuilder.Entity<PurchaseHistory>().HasData(new List<PurchaseHistory>()
            {
             new PurchaseHistory() { AvailableProgramId = 1, CustomerId = 1, PurchaseDate = new DateTime(2022, 11, 12), Rating = 6},
             new PurchaseHistory() { AvailableProgramId = 2, CustomerId = 1, PurchaseDate = new DateTime(2022, 11, 14), Rating = 8}
            });
    }
    
}