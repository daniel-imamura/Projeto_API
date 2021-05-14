using Microsoft.EntityFrameworkCore;
using ProjetoEscola_API.Models;

namespace ProjetoEscola_API.Data
{
    public class EscolaContext: DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options): base (options)
        {
        }
        public DbSet<Aluno> Aluno {get; set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}