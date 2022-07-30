using AppBoletim.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppBoletim.Controllers
{
    public class AlunoController : Controller
    {
        static List<AlunoModel> lista = new List<AlunoModel>();
        public IActionResult Index()
        {
            lista.Add(new AlunoModel()
            {
                Id = 1,
                LastName = "Sant Anna",
                Name = "Willian",
                Adress = "Rua Tribal, 68 - Recreio dos Bandeirantes, RJ",
                DataNascimento = new DateOnly(1990, 08, 31),
                Idade = 32,
                Materias = new List<Materia>
                {
                    new Materia() { Id = 1, Name = "Português", Notas = new List<double> {5, 6.5, 6.5, 0 } },
                    new Materia() { Id = 2, Name = "Matemática", Notas = new List<double> {10, 8, 8 , 8} },
                    new Materia() { Id = 2, Name = "Ciências", Notas = new List<double> {6, 7.5, 8, 8 } },
                    new Materia() { Id = 2, Name = "História", Notas = new List<double> {8, 9, 10, 7.5 } },

                }
            });

            ViewBag.Lista = lista;
            return View();

        }

    }
}
