using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creamos una lista de tareas usando una lista de objetos de la clase Tarea.
        List<Tarea> tareas = new List<Tarea>();

        while (true)
        {
            Console.WriteLine("---- Lista de Tareas ----");
            Console.WriteLine("1. Agregar Tarea");
            Console.WriteLine("2. Marcar Tarea como Completada");
            Console.WriteLine("3. Listar Tareas Pendientes");
            Console.WriteLine("4. Salir");
            Console.Write("Elija una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el título de la tarea: ");
                    string titulo = Console.ReadLine();
                    Tarea nuevaTarea = new Tarea(titulo);
                    tareas.Add(nuevaTarea);
                    Console.WriteLine("Tarea agregada con éxito.");
                    break;

                case 2:
                    Console.Write("Ingrese el número de la tarea a marcar como completada: ");
                    int tareaIndex = int.Parse(Console.ReadLine()) - 1;

                    if (tareaIndex >= 0 && tareaIndex < tareas.Count)
                    {
                        tareas[tareaIndex].MarcarComoCompletada();
                        Console.WriteLine("Tarea marcada como completada.");
                    }
                    else
                    {
                        Console.WriteLine("Número de tarea no válido.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Tareas Pendientes:");
                    for (int i = 0; i < tareas.Count; i++)
                    {
                        if (!tareas[i].Completada)
                        {
                            Console.WriteLine($"{i + 1}. {tareas[i].Titulo}");
                        }
                    }
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}

class Tarea
{
    public string Titulo { get; }
    public bool Completada { get; private set; }

    public Tarea(string titulo)
    {
        Titulo = titulo;
        Completada = false;
    }

    public void MarcarComoCompletada()
    {
        Completada = true;
    }
}
