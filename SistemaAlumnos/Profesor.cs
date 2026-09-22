namespace SistemaAlumnos;

// Etapa 7
public class Profesor : Persona, IExportable
{
    public string Materia { get; set; } = "";

    public Profesor(string nombre, int documento, string materia) : base(nombre, documento)
    {
        Materia = materia;
    }
    // Etapa 8
    public override string Presentarse()
    {
        return $"Hola, soy {Nombre} y dicto {Materia}.";
    }
    // Etapa 9
    public string ExportarLinea()
    {
        return $"PROFESOR;{Nombre};{Materia}";
    }
}