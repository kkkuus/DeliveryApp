using Microsoft.EntityFrameworkCore;
using versta_test.Models;

namespace versta_test.Data;

public class OrderContext : DbContext
{
    public OrderContext(DbContextOptions<OrderContext> options) : base(options){}
    
    public DbSet<Order> Orders { get; set; }
    
}