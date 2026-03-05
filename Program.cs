using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_10_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desarrolle un programa con menú que permita agregar y mostrar estudiantes usando un Dictionary.");
            Dictionary<int, string>estudiantes=new Dictionary<int, string>();
            int id;
            string nombre;
            int opcion;
            do
            {
                Console.WriteLine("1. ingresar estudiante");
                Console.WriteLine("2. ver estudiantes");
                Console.WriteLine("0. salir");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese cantidad de estudiantes que desae ingresar: ");
                        int.TryParse(Console.ReadLine(), out int lim);
                        for (int i = 0; i < lim; i++)
                        {


                            Console.WriteLine($"Ingrese carne de estudiante");
                            int.TryParse(Console.ReadLine(), out id);
                            if (estudiantes.ContainsKey(id))
                            {
                                Console.WriteLine("carne ya existente");
                                i--;
                            }
                            else
                            {
                                Console.WriteLine("ingrese nombre:");
                                nombre = Console.ReadLine();
                                estudiantes.Add(id, nombre);

                            }
                        }
                        break;
                    case 2:
                        foreach (var item in estudiantes)
                        {
                            Console.WriteLine(" el carne: " + item.Key + " estudainte: " + item.Value);
                        }

                        break;
                    
                   
                    default:
                        Console.WriteLine("ingrese valor valido");
                        break;
                }

            }
            while (opcion!=0);
            Console.WriteLine("hasta luego");


        }
    }
}
