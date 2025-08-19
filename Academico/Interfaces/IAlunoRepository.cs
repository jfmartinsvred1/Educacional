using Academico.Models;

namespace Academico.Interfaces
{
    public interface IAlunoRepository
    {
        Task Add(Aluno aluno);
        Task<IEnumerable<Aluno>> GetAll();
    }
}
