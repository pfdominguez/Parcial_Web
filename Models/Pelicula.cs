namespace Parcial_Web.Models;
public class Pelicula
{

    public int Id { get; set; }
    public int ActorId { get; set; }
    public string Nombre { get; set; }
    public string Genero { get; set; }
    public virtual Actor? Actor { get; set; }
}