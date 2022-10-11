namespace WikiClase.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int categoriaId { get; set; }
        public Categoria Categorias { get; set; }

    }
}
