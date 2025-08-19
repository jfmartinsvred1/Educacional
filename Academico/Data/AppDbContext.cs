using Academico.Models;
using Microsoft.EntityFrameworkCore;

namespace Academico.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions opts):base(opts)
        {
            
        }
        public DbSet<Aluno> Alunos { get; set; }
    }
}
