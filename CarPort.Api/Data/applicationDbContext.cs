using Microsoft.EntityFrameworkCore;
using CarPort.Api.Models;

namespace CarPort.Api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }


}