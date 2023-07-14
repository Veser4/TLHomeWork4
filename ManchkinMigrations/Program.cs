using ManchkinMigrations;
using Microsoft.EntityFrameworkCore;

namespace ManchkinMigrations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new ContextFactory().CreateDbContext(args).Database.Migrate();
        }
    }
}