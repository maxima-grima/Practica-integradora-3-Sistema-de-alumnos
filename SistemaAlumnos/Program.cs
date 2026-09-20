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
// Etapa 2
Alumno alumno1 = new Alumno("Ana Pérez", 1234, 7, 7);
Alumno alumno2 = new Alumno("Juan Gómez", 5678, 5, 8);

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
// Etapa 3 
Alumno alumno4 = new Alumno("Luis Díaz", 9012, 9.5, 10);

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
/*  CS0114  'Alumno.ToString()' oculta el miembro heredado 'object.ToString()'. Para hacer que el miembro actual invalide esa implementación, agregue la palabra clave override. Si no, agregue la palabra clave new.
 */