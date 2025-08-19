using Academico.Interfaces;
using Academico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepository _repository;
        public AlunoController(IAlunoRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Create()
        {
            return View();

        }

        public async Task<IActionResult> Index()
        {
            var alunos = await _repository.GetAll();
            return View(alunos);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Aluno aluno)
        {
            await _repository.Add(aluno);
            return RedirectToAction("Index");   
        }
    }
}
