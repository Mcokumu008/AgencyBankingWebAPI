using Microsoft.EntityFrameworkCore;
using AgencyBankingWebAPI.Models;
namespace AgencyBankingWebAPI.Data
{
    public class ApiContext: DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options)
           : base(options)
            { }
    }
}
