namespace CatalogoInMemory.Models
{
    public class ActorModel
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public List<MovieModel> Movies { get; set; }
        
    }
}
