using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-BCNGC9H\\SQLEXPRESS01; initial catalog=DesignPattern1;TrustServerCertificate=True;" +
                "integrated security=true;");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }

    }

}
