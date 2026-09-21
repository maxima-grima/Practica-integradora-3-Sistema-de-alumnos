namespace SistemaAlumnos;

// Etapa 7
public class Persona
{
    public string Nombre { get; set; } = "";
    public int Documento { get; private set; }

    public Persona(string nombre, int documento)
    {
        Nombre = nombre;
        Documento = documento;
    }
}