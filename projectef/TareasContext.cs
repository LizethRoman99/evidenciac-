using Microsoft.EntityFrameworkCore;
using projectef.Models;

public class TareasContext:DbContext{

    public DbSet<Categoria> Categorias{get; set;}
    public DbSet<Tarea> Tareas { get; set; }


    public TareasContext (DbContextOptions<TareasContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelbuilder){
        modelbuilder.Entity<Categoria>(categoria=>
        {
            categoria.ToTable("Categoria");//crear la tabla categoria
            categoria.HasKey(p=> p.CategoriaId);//crea la categoria 
            //regrese el modelo de categorias y comenta la linea key ya no es requerida
            categoria.Property(p=>p.Nombre).IsRequired().HasMaxLength(150);//crear y validar el campo categoria
            categoria.Property(p=>p.Descripcion);
            categoria.Property(p=>p.Peso);

        });   
        modelbuilder.Entity<Tarea>(tarea=>//crear la entidad tarea
        {
            tarea.ToTable("Tarea");//crear la tabla tarea
            tarea.HasKey(P=>P.TareaId);//crear la pk de la tabla
            tarea.HasOne(p=>p.Categoria).WithMany(p=>p.Tareas).HasForeignKey(p=>p.CategoriaId);
            tarea.Property(p=>p.Titulo).IsRequired().HasMaxLength(200);
            tarea.Property(p=>p.Descripcion);
            tarea.Property(p=>p.PrioridadTarea);
            tarea.Property(p=>p.FechaCreacion);

        }
        
        );
    }


}