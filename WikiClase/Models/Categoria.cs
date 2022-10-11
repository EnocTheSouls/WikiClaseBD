namespace WikiClase.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<Tag> tag { get; set; }
    }
}
