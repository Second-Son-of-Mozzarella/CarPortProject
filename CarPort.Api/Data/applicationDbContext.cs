using Microsoft.EntityFrameworkCore;

namespace CarPort.Api.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }


}