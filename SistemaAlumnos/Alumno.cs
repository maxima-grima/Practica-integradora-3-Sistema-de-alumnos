namespace SistemaAlumnos;

public class Alumno
{
    // Etapa 1
    public string Nombre { get; set; } = "";
    /*
    public int Legajo { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    */
    // Etapa 5
    public int Legajo { get; private set; }
    public double Nota1 { get; private set; }
    public double Nota2 { get; private set; }

    /* Etapa 2
    public Alumno(string nombre, int legajo, double nota1, double nota2)
    {
        Nombre = nombre;
        Legajo = legajo;
        Nota1 = nota1;
        Nota2 = nota2;
    }
    */
    // Etapa 5
    public Alumno(string nombre, int legajo)
    {
        Nombre = nombre;
        Legajo = legajo;
    }
    // Etapa 3
    public double Promedio()
    {
        return (Nota1 + Nota2) / 2;
    }

    public bool EstaAprobado()
    {
        return Promedio() >= 6;
    }

    public void SubirNota()
    {
        Nota1 = Math.Min(Nota1 + 1, 10);
        Nota2 = Math.Min(Nota2 + 1, 10);
    }
    // Etapa 4
    public override string ToString()
    {
        return $"{Legajo} - {Nombre} (promedio: {Promedio()})";
    }
    // Etapa 5
    public bool CargarNotas(double nota1, double nota2)
    {
        if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10)
        {
            return false;
        }

        Nota1 = nota1;
        Nota2 = nota2;
        return true;
    }
}
