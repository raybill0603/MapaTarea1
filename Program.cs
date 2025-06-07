using System;

namespace ComunidadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante
            {
                Nombre = "Ana Torres",
                Cedula = "402-1234567-8",
                Carrera = "Ingeniería en Software"
            };

            estudiante.MostrarInformacion();
            Console.WriteLine($"Carrera: {estudiante.Carrera}\n");

            Administrador admin = new Administrador
            {
                Nombre = "Carlos Ramírez",
                Cedula = "001-9876543-2",
                Departamento = "Tecnología",
                AreaDeEnseñanza = "Redes",
                NivelDeAcceso = "Alto"
            };

            admin.MostrarInformacion();
            Console.WriteLine($"Departamento: {admin.Departamento}");
            Console.WriteLine($"Área: {admin.AreaDeEnseñanza}");
            Console.WriteLine($"Nivel de acceso: {admin.NivelDeAcceso}\n");

            ExAlumno exAlumno = new ExAlumno
            {
                Nombre = "Lucía Pérez",
                Cedula = "001-1111111-3",
                AñoGraduacion = 2029
            };

            exAlumno.MostrarInformacion();
            Console.WriteLine($"Año de Graduación: {exAlumno.AñoGraduacion}");
        }
    }
}

