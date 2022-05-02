using System;


namespace MiClasePersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un objeto instanciado
            Persona p = new Persona();
            p.hablar();

            p.setNombre("Robert");
            Console.WriteLine("EL Nombre: " + p.getNombre() + " ha sido modificado");

            Console.ReadKey();
        }
    }
}
