using System;



namespace ProyectoFinalBack;

public class Clase
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int Horario { get; set; }
    public string Instructor { get; set; }
}

public class Socio
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string CorreoElectronico { get; set; }
    public int Telefono { get; set; }
    public string Sexo { get; set; }
}