using Microsoft.EntityFrameworkCore;

namespace ClothesStoreInfrastructure.Context
{
    public class ClothesStoreDbContext : DbContext
    {
        public ClothesStoreDbContext(DbContextOptions<ClothesStoreDbContext> options)
            :base(options) { }


    }
}
