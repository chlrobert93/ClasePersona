using System;


namespace MiClasePersona
{
     class Persona
    {

        //Caracteristicas de la persona
        string nombre;
        int ojos, brazos, piernas;
        string color_ojos;
        string color_pelo;


       //Comportamiento mediante métodos
       public void andar (int velocidad)
        {
            Console.WriteLine("La persona  anda a: " + velocidad + " por hora");
        }
         
        //Método hablar
        public void hablar()
        {
            Console.WriteLine("La persona esta hablando jojojo");
        }


        //Nos va devolver el atributo nombre
        public string getNombre()
        {
            return nombre;
        }

        //Modificar, establecer el nombre de la persona 
        public void setNombre(string nombre)
        {
            this.nombre = nombre;

        }


    }
}
