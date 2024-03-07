using System.ComponentModel.DataAnnotations;
using projectef.Models;

public class Categoria{
    // [Key]
        public Guid CategoriaId{get;set;}
        //se comentan estas lineas porque pueden entrar en conflicto
        // [Required]
        // [MaxLength(150)]

    public string Nombre{get;set;}

    public string Descripcion {get;set;}
    public virtual ICollection<Tarea> Tareas{get;set;}

    public int Peso {get;set;}
}