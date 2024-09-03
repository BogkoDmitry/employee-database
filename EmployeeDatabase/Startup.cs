using EmployeeDatabase.DAL;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDatabase
{
    public sealed class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {

            var connectionString = _configuration.GetConnectionString("DevConnection");

            services.AddDbContext<EDBContext>(options => options.UseNpgsql(connectionString));
        }

        public void Configure(IApplicationBuilder app)
        {

        }
    }
}
