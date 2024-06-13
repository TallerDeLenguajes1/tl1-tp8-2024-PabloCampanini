namespace EspacioTarea;

public class Tarea
{
    //Atributos privados
    private int tareaId;    //Numerado en ciclo iterativo
    private string descripcion;
    private int duracion;   //Numero entre 10 - 100

    //Propiedades
    public int TareaID
    {
        get => tareaId;
        set => tareaId = value;
    }
    public string Descripcion 
    { 
        get => descripcion; 
        set => descripcion = value; 
    }
    public int Duracion 
    { 
        get => duracion; 
        set => duracion = value; 
    }

    //Constructor
    public Tarea(int tareaId, string descripcion, int duracion)
    {
        this.TareaID = tareaId;
        this.Descripcion = descripcion;
        this.Duracion = duracion;
    }

    //Metodos
    public void MostrarTareasPendientes()
    {
        Console.WriteLine("\n\t\t*----- Lista de Tareas Pendientes -----");

        Console.WriteLine($"\nTarea {tareaId}:");

        Console.WriteLine($"\t\tDescripcion: {Descripcion}");
        Console.WriteLine($"\t\tDuracion: {Duracion}");
    }
    public void MostrarTareasRealizadas()
    {
        Console.WriteLine("\n\t\t*----- Lista de Tareas Realizadas -----");

        Console.WriteLine($"\nTarea {tareaId}:");

        Console.WriteLine($"\t\tDescripcion: {Descripcion}");
        Console.WriteLine($"\t\tDuracion: {Duracion}");
    }
}