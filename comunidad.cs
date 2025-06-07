public abstract class Comunidad
{
    public string? Nombre { get; set; }
    public string? Cedula { get; set; }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Cédula: {Cedula}");
    }
}
