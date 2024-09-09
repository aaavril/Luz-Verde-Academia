using System;
namespace Library;

public class Alumno
{
    public string Nombre { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Licencia { get; set; }

    public Alumno(string nombre, DateTime fechaNacimiento, string licencia)
    {
        Nombre = nombre;
        FechaNacimiento = fechaNacimiento;
        Licencia = licencia;
    }

    public string GetDetalles()
    {
        return $"{Nombre}, Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}, Licencia: {Licencia}";
    }

    public void AsignarAuto(Auto auto)
    {
        // Lógica para asignar un auto al alumno
    }
}