using System;
using System.Collections.Generic;
using System.IO;

class ProgramaInfo
{
    class Concepto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Concepto(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"Término: {Nombre}\nDescripción: {Descripcion}\n";
        }
    }

    static void Main()
    {
        List<Concepto> conceptos = ObtenerConceptosIniciales();
        MostrarConceptos(conceptos);

        Console.Write("¿Quieres añadir un término nuevo? (s/n): ");
        string opcion = Console.ReadLine().ToLower();

        if (opcion == "s")
        {
            AgregarConcepto(conceptos);
        }

        GuardarConceptos("terminos_tecnologia.txt", conceptos);
        Console.WriteLine("\nTérminos guardados correctamente en 'terminos_tecnologia.txt'");
    }

    static List<Concepto> ObtenerConceptosIniciales()
    {
        return new List<Concepto>
        {
            new Concepto("Machine Learning", "Rama de la IA que permite a los sistemas aprender de datos sin ser programados explícitamente."),
            new Concepto("Repositorio", "Lugar donde se almacena el código fuente de un proyecto y su historial."),
            new Concepto("Depuración", "Proceso para detectar y corregir errores en el software."),
            new Concepto("Lenguaje de programación", "Lenguaje utilizado para escribir instrucciones que ejecuta un ordenador."),
            new Concepto("Backend", "Parte de una aplicación que gestiona la lógica y las bases de datos, funcionando en el servidor."),
            new Concepto("Frontend", "Parte visual de una web o aplicación con la que interactúa el usuario."),
            new Concepto("Commit", "Acción de guardar un conjunto de cambios en el historial de un repositorio."),
            new Concepto("Script", "Archivo que contiene instrucciones escritas en lenguaje de scripting para ejecutar tareas."),
            new Concepto("Token", "Elemento usado en autenticación para verificar la identidad del usuario."),
            new Concepto("Servidor", "Equipo o programa que proporciona servicios a otros sistemas llamados clientes."),
            new Concepto("Cliente", "Dispositivo o software que consume los servicios ofrecidos por un servidor."),
            new Concepto("Puerto", "Canal de comunicación virtual en un sistema operativo para identificar procesos de red."),
            new Concepto("JSON", "Formato ligero de intercambio de datos, fácil de leer y escribir por humanos y máquinas."),
            new Concepto("Middleware", "Software que actúa como puente entre un sistema operativo o base de datos y aplicaciones."),
            new Concepto("API REST", "Tipo de API que sigue principios REST para permitir la comunicación entre sistemas a través de HTTP."),
            new Concepto("Hash", "Función que convierte datos en una cadena fija, útil para verificar integridad y seguridad."),
            new Concepto("Compilación", "Proceso que transforma el código fuente en un archivo ejecutable."),
            new Concepto("Carga dinámica", "Técnica donde los recursos se cargan en tiempo de ejecución según necesidad."),
            new Concepto("Testing", "Pruebas que se realizan al software para verificar que funciona correctamente."),
            new Concepto("Repositorio remoto", "Copia de un proyecto almacenada en línea para compartir y colaborar.")
        };
    }

    static void MostrarConceptos(List<Concepto> lista)
    {
        Console.WriteLine("\n--- Lista de Conceptos de Informática ---\n");
        foreach (var item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }

    static void AgregarConcepto(List<Concepto> lista)
    {
        Console.Write("\nNuevo término: ");
        string nombre = Console.ReadLine();

        Console.Write("Descripción: ");
        string descripcion = Console.ReadLine();

        lista.Add(new Concepto(nombre, descripcion));
    }

    static void GuardarConceptos(string archivo, List<Concepto> lista)
    {
        using (StreamWriter sw = new StreamWriter(archivo))
        {
            foreach (var concepto in lista)
            {
                Console.WriteLine(concepto.ToString());
            }
        }
    }
}