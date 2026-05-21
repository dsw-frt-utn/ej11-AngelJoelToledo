using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList CasoList = new CasoList();
        CasoList.AgregarAlumno(new Alumno(1, "Juan", 8.5));
        CasoList.AgregarAlumno(new Alumno(2, "Manuel", 8));
        CasoList.AgregarAlumno(new Alumno(3, "Rol", 7.5));


        Console.WriteLine("listaAlumnos");
        var listaAlumnos = CasoList.RetornarListaAlumnos();
        foreach (var alumno in listaAlumnos)
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\n Alumno buscado:");
        Alumno alumnoBuscado = CasoList.BuscarAlumno("Juan");
        Console.WriteLine(alumnoBuscado);

        Console.WriteLine("\n Alumno buscado2:");
        Alumno alumnoBuscado2 = CasoList.BuscarAlumno("Maria");
        if (alumnoBuscado2 != null) 
            Console.WriteLine(alumnoBuscado2);
        else
            Console.WriteLine("No existe");


        Alumno alumnoEliminado = CasoList.BuscarAlumno("Manuel");
        CasoList.EliminarAlumno(alumnoEliminado);

        Console.WriteLine("\n listaAlumnosModificadaPorEliminacion");
        listaAlumnos = CasoList.RetornarListaAlumnos();
        foreach (var alumno in listaAlumnos)
        {
            Console.WriteLine(alumno);
        }


        //Alumno alumnoEliminado2 = CasoList.BuscarAlumno("Juan");
        //int indexAlumnoEliminado2 = CasoList.RetornarListaAlumnos().IndexOf(alumnoEliminado2);
        CasoList.EliminarAlumnoPorPosicion(0);

        Console.WriteLine("\n listaAlumnosModificadaPorEliminacionPorPosicion");
        listaAlumnos = CasoList.RetornarListaAlumnos();
        foreach (var alumno in listaAlumnos)
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary CasoDictionary = new CasoDictionary();
        CasoDictionary.AgregarAlumno(new Alumno(1, "Juan", 8.5));
        CasoDictionary.AgregarAlumno(new Alumno(2, "Manuel", 8));
        CasoDictionary.AgregarAlumno(new Alumno(3, "Rol", 7.5));

        Console.WriteLine("DiccionarioAlumnos:");
        var diccionarioAlumnos = CasoDictionary.RetornarDiccionario();
        foreach (KeyValuePair<int, Alumno> alumnos in diccionarioAlumnos)
        {
            //int llave = alumnos.Key;
            Alumno alumnosValor = alumnos.Value;

            //Console.WriteLine($"{llave}: {alumnosValor}");
            //-- No es necesario mostrar la llave, ya que esta es el Id el cual de por si ya es parte de la clase alumno.
            Console.WriteLine(alumnosValor);
        }

        Console.WriteLine("\n Alumno buscado:");
        var alumnoBuscado = CasoDictionary.BuscarAlumno(1);
        Console.WriteLine(alumnoBuscado);

        Console.WriteLine("\n Alumno buscado:");
        var alumnoBuscado2 = CasoDictionary.BuscarAlumno(10);
        if (alumnoBuscado2 != null)
            Console.WriteLine(alumnoBuscado2);
        else
            Console.WriteLine("No existe");



        Console.WriteLine("\n DiccionarioAlumnosModificadoPorEliminacion:");
        CasoDictionary.EliminarAlumno(2);

        var diccionarioAlumnos2 = CasoDictionary.RetornarDiccionario();
        foreach (KeyValuePair<int, Alumno> alumnos in diccionarioAlumnos2)
        {
            Console.WriteLine(alumnos.Value);
        }



    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

        

    }
}
