// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Ejercicio 1 - Listas del TP-04


/*
using EspacioTarea;

List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas = new List<Tarea>();

int Seguir = 1; //1: Carga mas tareas, 0: No carga mas tareas
string Pregunta; //Aux para manejar seguir
string Descripcion; //variable para guardar la descripcion de la tarea
string TiempoDuracion;  //Guardar el tiempo de duracion de la tarea
int Id = 0; //Id que ira incrementando con el propio cargado de la tarea

while (Seguir == 1)
{
    Console.WriteLine($"\nIngrese los datos de la tarea a realizar: ");

    Console.WriteLine($"Descripcion:");
    Descripcion = Console.ReadLine();

    Console.WriteLine($"Duracion:");
    TiempoDuracion = Console.ReadLine();

    if (int.TryParse(TiempoDuracion, out int Duracion))
    {
        TareasPendientes.Add(new Tarea(Id, Descripcion, Duracion));
    }

    Console.WriteLine($"\n\nQuiere agregar otra tarea? S/N");
    Pregunta = Console.ReadLine();

    Id++;

    if (Pregunta == "n" || Pregunta == "N")
    {
        Seguir = 0;
    }
}

Console.WriteLine("\n\t\t*----- Lista de Tareas Pendientes -----");

foreach (Tarea Pendiente in TareasPendientes)
{
    Pendiente.MostrarTareasPendientes();
}

//Restauro el valor de seguir en 1
Seguir = 1;

while (Seguir == 1)
{
    Console.WriteLine($"\nQuiere marcar una tarea como realizada?  S/N");
    Pregunta = Console.ReadLine();

    if (Pregunta == "s" || Pregunta == "S")
    {
        Console.WriteLine($"\nIngrese el numero de la tarea que quiere marcar como realizada: ");

        if (int.TryParse(Console.ReadLine(), out int PreguntaId))
        {
            TareasRealizadas.Add(TareasPendientes[PreguntaId]);
            TareasPendientes.RemoveAt(PreguntaId);
        }

        Console.WriteLine("\n\t\t*----- Lista de Tareas Pendientes -----");

        foreach (Tarea Pendiente in TareasPendientes)
        {
            Pendiente.MostrarTareasPendientes();
        }

        Console.WriteLine($"\nQuiere marcar otra tarea como realizada? S/N");
        Pregunta = Console.ReadLine();

        if (Pregunta == "n" || Pregunta == "N")
        {
            Console.WriteLine("\n\t\t*----- Lista de Tareas Pendientes -----*");

            foreach (Tarea Pendiente in TareasPendientes)
            {
                Pendiente.MostrarTareasPendientes();
            }

            Console.WriteLine("\n\t\t*----- Lista de Tareas Realizadas -----*");

            foreach (Tarea Realizada in TareasRealizadas)
            {
                Realizada.MostrarTareasRealizadas();
            }

            Seguir = 0;
        }
    }
    else
    {
        Console.WriteLine("\n\t\t*----- Lista de Tareas Pendientes -----*");

        foreach (Tarea Pendiente in TareasPendientes)
        {
            Pendiente.MostrarTareasPendientes();
        }

        Console.WriteLine("\n\t\t*----- Lista de Tareas Realizadas -----*");

        foreach (Tarea Realizada in TareasRealizadas)
        {
            Realizada.MostrarTareasRealizadas();
        }

        Seguir = 0;
    }
}

Console.WriteLine($"\nQuiere buscar en la lista de tareas pendientes por una palabra clave? S/N");

Seguir = 1;

while (Seguir == 1)
{
    Pregunta = Console.ReadLine();

    if (Pregunta == "s" || Pregunta == "S")
    {
        Console.WriteLine("\nIngrese la palabra que quiere buscar: ");

        string PalabraBuscada = Console.ReadLine();

        foreach (Tarea Pendientes in TareasPendientes)
        {
            if (Pendientes.ContenidoDescripcion(PalabraBuscada))
            {
                Pendientes.MostrarTareasPendientes();
            }
        }

        Console.WriteLine("Quiere haceer otra buusqueda? S/N");
        Pregunta = Console.ReadLine();

        if (Pregunta == "n" || Pregunta == "N")
        {
            Seguir = 0;
        }
    }
    else
    {
        Seguir = 0;
    }
}
*/




//Ejercicio 2 - Implementacion de, historial en la calculadora TP-07


using EspacioCalculadora;

Calculadora calc = new Calculadora();

Console.WriteLine("\n\n\t\t*----- Calculadora -----*");

Console.WriteLine("Ingrese un numero base: ");

string oracion = Console.ReadLine();

if (double.TryParse(oracion, out double numBase))
{
    calc.Sumar(numBase);

    int seguir = 1;

    while (seguir == 1)
    {
        Console.WriteLine("\nOperaciones:\n\t1. Suma\n\t2. Resta\n\t3. Multiplicacion\n\t4. Division\n\t5. Limpiar (Reinicia el numerro base en 0)\n\t6. Mostrar historial\n\n\n\t7. Salir");

        Console.WriteLine("\n\nIngrese el numero de la operacion que quiere realizar");

        string cadena = Console.ReadLine();

        seguir = OperacionElegida(cadena, seguir);
    }
}

int OperacionElegida(string cadena, int seguir)
{
    if (int.TryParse(cadena, out int operacion))
    {
        if (operacion == 7)
        {
            seguir = 0;
        }
        else
        {
            Console.WriteLine("Ingrese un numero: ");

            string oracion2 = Console.ReadLine();

            if (double.TryParse(oracion2, out double numero))
            {
                switch (operacion)
                {
                    case 1:
                        calc.Sumar(numero);
                        Console.WriteLine($"\n\t\t*----- El resultado de la suma es = {calc.Resultado} -----*\n");
                        seguir = 1;
                        break;
                    case 2:
                        calc.Restar(numero);
                        Console.WriteLine($"\n\t\t*----- El resultado de la resta es = {calc.Resultado} -----*\n");
                        seguir = 1;
                        break;
                    case 3:
                        calc.Multiplicar(numero);
                        Console.WriteLine($"\n\t\t*----- El resultado del producto es = {calc.Resultado} -----*\n");
                        seguir = 1;
                        break;
                    case 4:
                        if (numero != 0)
                        {
                            calc.Dividir(numero);
                            Console.WriteLine($"\n\t\t*----- El resultado de la division es = {calc.Resultado} -----*\n");
                            seguir = 1;
                        }
                        else
                        {
                            Console.WriteLine("El 2do numero debe ser distinto de 0 para la division");
                            seguir = 1;
                        }
                        break;
                    case 5:
                        calc.Limpiar();
                        break;
                    case 6:
                        calc.MostrarHistorial();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
    else
    {
        Console.WriteLine("\n\t\t*----- Ingrese un dato valido -----*");
    }

    return seguir;
}