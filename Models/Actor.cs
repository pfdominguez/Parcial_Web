namespace Parcial_Web.Models;
public class Actor
{

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
   public virtual ICollection<Pelicula>? Peliculas { get; set; }

}