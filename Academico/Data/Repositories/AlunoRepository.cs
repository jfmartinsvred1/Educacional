using Academico.Interfaces;
using Academico.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Academico.Data.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly AppDbContext _context;

        public AlunoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Add(Aluno aluno)
        {
            await _context.Alunos.AddAsync(aluno);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Aluno>> GetAll()
        {
            var response = await _context.Alunos.ToListAsync();
            return response;
        }
    }
}
