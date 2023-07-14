using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DataBaseProvider;
using DataBaseProvider.Repositories;

namespace ManchkinMigrations
{
    internal class ContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            string connectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Manchkin;Pooling=true;Integrated Security=SSPI";
            var optionalBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            optionalBuilder.UseSqlServer(connectionString,
                assembly => assembly.MigrationsAssembly("ManchkinMigrations"));

            return new ApplicationContext(optionalBuilder.Options);
        }
    }
}
