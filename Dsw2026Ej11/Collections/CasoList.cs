using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    public List<Alumno>? listaAlumnos = new List<Alumno>(); 

    public void AgregarAlumno (Alumno alumno)
    {
        listaAlumnos?.Add(alumno);
    }

    public List<Alumno> RetornarListaAlumnos()
    {
       
        return listaAlumnos ?? new List<Alumno>();

    }

    public Alumno BuscarAlumno(string nombre)
    {
        return listaAlumnos?.Find(a => a.Nombre == nombre);
    }

    public void EliminarAlumno (Alumno alumno)
    {
        listaAlumnos?.Remove(alumno);
    }

    public void EliminarAlumnoPorPosicion (int index)
    {
        listaAlumnos?.RemoveAt(index);
    }

}
