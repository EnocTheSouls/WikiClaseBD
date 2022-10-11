namespace WikiClase.Models
{
    public class Post
    {
        public int Id { get; set; }
        
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public int categoriaId { get; set; }

        public Categoria categoria { get; set; }
    }
}
