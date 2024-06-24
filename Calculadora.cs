namespace EspacioCalculadora;

using Historial;

class Calculadora
{
    //Campos
    private double dato;
    List<Operacion> historial = new List<Operacion>();

    //Metodos
    public void Sumar (double termino)
    {
        historial.Add(new Operacion(dato, termino, Operacion.TipoOperacion.Suma));
        dato = dato + termino;
    }

    public void Restar (double termino)
    {
        historial.Add(new Operacion(dato, termino, Operacion.TipoOperacion.Resta));
        dato = dato - termino;
    }

    public void Multiplicar (double termino)
    {
        historial.Add(new Operacion(dato, termino, Operacion.TipoOperacion.Multiplicacion));
        dato = dato * termino;
    }

    public void Dividir (double termino)
    {
        if (termino != 0)
        {
            historial.Add(new Operacion(dato, termino, Operacion.TipoOperacion.Division));
            dato = dato / termino;
        }
        else
        {
            Console.WriteLine("Error division por 0");
        }
    }

    public void Limpiar ()
    {
        historial.Add(new Operacion(dato, 0, Operacion.TipoOperacion.Limpiar));
        dato = 0;
    }
    public void MostrarHistorial()
    {
        foreach (Operacion operacion in historial)
        {
            operacion.MostrarOperacion();
        }
    }

    //Propiedad
    public double Resultado{
        get => dato;
    }
}