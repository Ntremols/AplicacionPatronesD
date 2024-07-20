namespace SRP
{
    public class Persona
    {
        private string? nombre;
        private int? edad;
        private string? direccion;
        private string? correoElectronico;
    }
    
     public class CrearDatos
     {
         Console.WriteLine($"Nombre: {nombre}");
         Console.WriteLine($"Edad: {edad}");
         Console.WriteLine($"Direccion: {direccion}");
         Console.WriteLine($"Correo Electronico: {correoElectronico}");
     }
    

    public class EnviarCorreoElectronico(string correoElectronico, string mensaje)
    {
        //logica para enviar correo electronico 
    }
}
    