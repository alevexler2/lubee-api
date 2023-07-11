
namespace lubee_web_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
