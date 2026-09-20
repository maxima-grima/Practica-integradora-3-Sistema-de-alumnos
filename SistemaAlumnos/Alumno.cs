namespace SistemaAlumnos;

public class Alumno
{
    // Etapa 1
    public string Nombre { get; set; } = "";
    public int Legajo { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    // Etapa 2
    public Alumno(string nombre, int legajo, double nota1, double nota2)
    {
        Nombre = nombre;
        Legajo = legajo;
        Nota1 = nota1;
        Nota2 = nota2;
    }
}