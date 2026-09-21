using SistemaAlumnos;
/* Etapa 1
Alumno alumno1 = new Alumno();
alumno1.Nombre = "Ana Pérez";
alumno1.Legajo = 1234;
alumno1.Nota1 = 7;
alumno1.Nota2 = 7;

Alumno alumno2 = new Alumno();
alumno2.Nombre = "Juan Gómez";
alumno2.Legajo = 5678;
alumno2.Nota1 = 9;
alumno2.Nota2 = 8;
*/
/* Etapa 2
Alumno alumno1 = new Alumno("Ana Pérez", 1234, 7, 7);
Alumno alumno2 = new Alumno("Juan Gómez", 5678, 5, 8);
*/
// Etapa 7
Alumno alumno1 = new Alumno("Ana Pérez", 40123456, 1234);
alumno1.CargarNotas(7, 7);
Alumno alumno2 = new Alumno("Juan Gómez", 41234567, 5678);
alumno2.CargarNotas(5, 8);
Console.WriteLine($"{alumno1.Nombre} - {alumno1.Legajo}");
Console.WriteLine($"{alumno2.Nombre} - {alumno2.Legajo}");
alumno1.Nombre = "Ana María Pérez";
Console.WriteLine(alumno1.Nombre);
Console.WriteLine(alumno2.Nombre);
/* Etapa 2 - punto 3
Alumno alumno3 = new Alumno();

Error: CS7036 No se ha dado ningún argumento que corresponda al parámetro requerido "nombre" de "Alumno.Alumno(string, int, double, double)" 
Por qué: al escribir un constructor propio, C# ya no crea el constructor vacío por defecto. Ahora Alumno exige nombre, legajo y notas, y new Alumno() no pasa ningún dato.
*/
/*Etapa 3 
Alumno alumno4 = new Alumno("Luis Díaz", 9012, 9.5, 10);
 Etapa 7*/
Alumno alumno4 = new Alumno("Luis Díaz", 42345678, 9012);
alumno4.CargarNotas(9.5, 10);
// Etapa 3
Console.WriteLine($"Promedio de {alumno1.Nombre}: {alumno1.Promedio()}");
Console.WriteLine($"Promedio de {alumno2.Nombre}: {alumno2.Promedio()}");
Console.WriteLine($"Promedio de {alumno4.Nombre}: {alumno4.Promedio()}");

Console.WriteLine($"{alumno1.Nombre} aprobado: {alumno1.EstaAprobado()}");
Console.WriteLine($"{alumno2.Nombre} aprobado: {alumno2.EstaAprobado()}");

alumno4.SubirNota();
Console.WriteLine($"{alumno4.Nombre} tras SubirNota: {alumno4.Nota1} y {alumno4.Nota2}");
/* Para pensar (Etapa 3): ninguno de los métodos recibe las notas por parámetro. ¿De dónde las saca?
Las saca del propio objeto. Nota1 y Nota2 son propiedades que cada alumno guarda como parte de sus datos, y los métodos de la clase pueden usarlas directamente.
Cuando se escribe alumno1.Promedio(), el método trabaja con las notas de alumno1; con alumno2.Promedio(), con las de alumno2. Por eso cada alumno devuelve su propio
promedio aunque el código del método sea uno solo.
*/
// Etapa 4
Console.WriteLine(alumno1);
Console.WriteLine(alumno2);
Console.WriteLine(alumno4);
/* Etapa 4 - punto 2: sin override
Advertencia: CS0114 'Alumno.ToString()' oculta el miembro heredado 'object.ToString()'. Para hacer que el miembro actual invalide esa implementación, agregue la palabra clave override. Si no, agregue la palabra clave new.
Qué pasó al ejecutar: imprimió SistemaAlumnos.Alumno tres veces, porque el ToString propio quedó oculto y Console.WriteLine usó el original de object.
*/
// Etapa 5
// alumno1.Nota1 = 47;

if (!alumno1.CargarNotas(47, 5))
{
    Console.WriteLine("Notas inválidas: tienen que estar entre 0 y 10");
}
Console.WriteLine(alumno1); // las notas no cambiaron
/* Etapa 5 - punto 2: alumno1.Nota1 = 47;
Error: CS0272 La propiedad o el indizador 'Alumno.Nota1' no se pueden usar en este contexto porque el descriptor de acceso set es inaccesible
Por qué: Nota1 ahora tiene private set, así que solo se puede modificar desde dentro de la clase Alumno.
*/
/* Para pensar (Etapa 5): ¿queda alguna forma de que un alumno tenga una nota de 47?
No. Las notas solo se pueden modificar desde dentro de la clase, y hay dos caminos: CargarNotas, que rechaza
cualquier valor fuera de 0 a 10 sin tocar nada, y SubirNota, que nunca pasa de 10. El constructor ya no recibe
notas, así que tampoco por ahí. Desde afuera solo se pueden leer.
*/
// Etapa 7
Profesor profesor1 = new Profesor("Marta Díaz", 25987654, "Programación");
Console.WriteLine($"{profesor1.Nombre} - {profesor1.Documento} - {profesor1.Materia}");
Console.WriteLine($"{alumno1.Nombre} - {alumno1.Documento}");
/* Para pensar (Etapa 7): ¿en cuántos archivos está escrita ahora la propiedad Nombre? ¿Cuántas clases la tienen?
Está escrita en un solo archivo, Persona.cs. La tienen tres clases (Persona, Alumno y Profesor), porque Alumno y Profesor la heredan y no la repiten.
*/
// Etapa 6
List<Alumno> alumnos = new List<Alumno> { alumno1, alumno2, alumno4 };
int opcion = 0;

while (opcion != 6)
{
    Console.WriteLine();
    Console.WriteLine("=== Sistema de alumnos ===");
    Console.WriteLine("1. Agregar alumno");
    Console.WriteLine("2. Listar alumnos");
    Console.WriteLine("3. Buscar alumno por legajo");
    Console.WriteLine("4. Promedio general del curso");
    Console.WriteLine("5. Cantidad de aprobados");
    Console.WriteLine("6. Salir");
    Console.Write("Opción: ");

    int.TryParse(Console.ReadLine(), out opcion);

    switch (opcion)
    {
        case 1:
            AgregarAlumno(alumnos);
            break;
        case 2:
            ListarAlumnos(alumnos);
            break;
        case 3:
            BuscarAlumno(alumnos);
            break;
        case 4:
            MostrarPromedioGeneral(alumnos);
            break;
        case 5:
            MostrarAprobados(alumnos);
            break;
        case 6:
            Console.WriteLine("Hasta luego");
            break;
        default:
            Console.WriteLine("Opción inexistente, elegí un número del 1 al 6");
            break;
    }
}
static void AgregarAlumno(List<Alumno> alumnos)
{
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine() ?? "";
    Console.Write("Documento: ");
    if (!int.TryParse(Console.ReadLine(), out int documento))
    {
        Console.WriteLine("Documento inválido, no se agregó el alumno");
        return;
    }
    Console.Write("Legajo: ");
    if (!int.TryParse(Console.ReadLine(), out int legajo))
    {
        Console.WriteLine("Legajo inválido, no se agregó el alumno");
        return;
    }

    Console.Write("Nota 1: ");
    if (!double.TryParse(Console.ReadLine(), out double nota1))
    {
        Console.WriteLine("Nota inválida, no se agregó el alumno");
        return;
    }

    Console.Write("Nota 2: ");
    if (!double.TryParse(Console.ReadLine(), out double nota2))
    {
        Console.WriteLine("Nota inválida, no se agregó el alumno");
        return;
    }

    Alumno nuevo = new Alumno(nombre, documento, legajo);

    if (!nuevo.CargarNotas(nota1, nota2))
    {
        Console.WriteLine("Notas inválidas: tienen que estar entre 0 y 10. No se agregó el alumno");
        return;
    }

    alumnos.Add(nuevo);
    Console.WriteLine("Alumno agregado");
}

static void ListarAlumnos(List<Alumno> alumnos)
{
    if (alumnos.Count == 0)
    {
        Console.WriteLine("Todavía no hay alumnos cargados");
        return;
    }

    foreach (Alumno alumno in alumnos)
    {
        Console.WriteLine(alumno); 
    }
}

static void BuscarAlumno(List<Alumno> alumnos)
{
    Console.Write("Legajo a buscar: ");
    if (!int.TryParse(Console.ReadLine(), out int legajo))
    {
        Console.WriteLine("Legajo inválido");
        return;
    }

    Alumno? encontrado = alumnos.Find(a => a.Legajo == legajo);

    if (encontrado == null)
    {
        Console.WriteLine("No existe un alumno con ese legajo");
    }
    else
    {
        Console.WriteLine(encontrado);
    }
}

static void MostrarPromedioGeneral(List<Alumno> alumnos)
{
    if (alumnos.Count == 0)
    {
        Console.WriteLine("Todavía no hay alumnos, no se puede calcular el promedio general");
        return;
    }

    double suma = 0;
    foreach (Alumno alumno in alumnos)
    {
        suma += alumno.Promedio();
    }

    Console.WriteLine($"Promedio general del curso: {suma / alumnos.Count}");
}

static void MostrarAprobados(List<Alumno> alumnos)
{
    int aprobados = 0;
    foreach (Alumno alumno in alumnos)
    {
        if (alumno.EstaAprobado())
        {
            aprobados++;
        }
    }

    Console.WriteLine($"Alumnos aprobados: {aprobados} de {alumnos.Count}");
}