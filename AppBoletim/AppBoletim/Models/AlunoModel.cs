namespace AppBoletim.Models
{
    public class AlunoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateOnly DataNascimento { get; set; }
        public int Idade { get; set; }
        public string Adress { get; set; }

        public List<Materia> Materias { get; set; } = new List<Materia>();

    }
    public class Materia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<double> Notas { get; set; }
        public string Status
        {
            get
            {
                double media = (Notas.Sum() / Notas.Count());

                if (media <= 6.0)
                {
                    return "Reprovado";
                }
                else
                {
                    return "Aprovado";
                }
            }
        }

    }
}
