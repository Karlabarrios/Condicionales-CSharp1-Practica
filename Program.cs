using System;

namespace CondicionalesUno
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("Ingrese su edad para obtener un descuento");
            edad = int.Parse(Console.ReadLine());

            if(edad > 21){
                if(edad > 30)
                    Console.WriteLine("Tienes 30 OFF");
                else
                    Console.WriteLine("Tienes 21 OFF");
            }else{
                Console.WriteLine("Tienes 10 OFF");
            }

            Console.WriteLine("Fin del programa de descuentos :D");
        }
    }
}
