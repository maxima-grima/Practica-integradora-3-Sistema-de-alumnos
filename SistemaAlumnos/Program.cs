using SistemaAlumnos;

// Etapa 1
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

Console.WriteLine($"{alumno1.Nombre} - {alumno1.Legajo}");
Console.WriteLine($"{alumno2.Nombre} - {alumno2.Legajo}");
alumno1.Nombre = "Ana María Pérez";
Console.WriteLine(alumno1.Nombre);
Console.WriteLine(alumno2.Nombre);
