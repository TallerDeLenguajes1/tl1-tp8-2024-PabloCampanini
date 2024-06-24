namespace Historial;

public class Operacion
{
    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar
    }

    //Campos
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;

    //Propiedades
    public double Resultado
    {
        get
        {
            switch (operacion)
            {
                case TipoOperacion.Suma: 
                    return resultadoAnterior + nuevoValor;
                case TipoOperacion.Resta:
                    return resultadoAnterior - nuevoValor;
                case TipoOperacion.Multiplicacion:
                    return resultadoAnterior * nuevoValor;
                case TipoOperacion.Division:
                    return resultadoAnterior / nuevoValor;
                default:
                    return 0;
            }
        }
    }
    public double NuevoValor
    {
        get => nuevoValor;
    }
    public double ResultadoAnterior
    {
        get => resultadoAnterior;
    }

    //Constructor
    public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
    {
        this.resultadoAnterior = resultadoAnterior;
        this.nuevoValor = nuevoValor;
        this.operacion = operacion;
    }

    //Metodo
    public void MostrarOperacion()
    {
        Console.WriteLine($"{operacion} de {ResultadoAnterior} y {NuevoValor} = {Resultado}");
    }
}