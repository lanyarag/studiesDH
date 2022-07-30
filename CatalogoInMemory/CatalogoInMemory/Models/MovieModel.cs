namespace CatalogoInMemory.Models
{
    public class MovieModel
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateOnly Premiere { get; set; }
            public TimeOnly Duration { get; set; }
            public List<ActorModel> Actors { get; set; }
    }
}
