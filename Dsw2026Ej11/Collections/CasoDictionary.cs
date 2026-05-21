using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    //Supondre que el id es el legajo
    private Dictionary<int, Alumno> DiccionarioAlumnos;
    public CasoDictionary()
    {
        DiccionarioAlumnos = new Dictionary<int, Alumno>();
    }


    public void AgregarAlumno(Alumno alumno)
    {
        DiccionarioAlumnos?.Add(alumno.Id, alumno);
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        return DiccionarioAlumnos?.GetValueOrDefault(legajo);
    }
    
    public Dictionary<int, Alumno>? RetornarDiccionario()
    {
        return DiccionarioAlumnos;
    }

    public void EliminarAlumno(int legajo)
    {
        DiccionarioAlumnos?.Remove(legajo);
    }

}


