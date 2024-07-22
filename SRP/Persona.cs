namespace SRP
{
    public class Persona
    {
          private string? nombre;
          private int? edad;
          private string? direccion;
          private string? correoElectronico;

          //public void EnviarCorreoElectronico(string mensaje)
          //{
          //  //logica para enviar correo electronico
          //}
          public void ImprimirDatos()
          {
              Console.WriteLine($"Nombre: {nombre}");
              Console.WriteLine($"Edad: {edad}");
              Console.WriteLine($"Direccion: {direccion}");
              Console.WriteLine($"Correo Electronico: {correoElectronico}");
          }
    }

    public class Email
    {
        public void EnviarEmail(string correoElectronico, string mensaje)
        {
            //logica para enviar correo electronico 
        }
    }
}
