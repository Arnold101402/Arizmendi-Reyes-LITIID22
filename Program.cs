using System.ComponentModel.Design;

namespace ProgramacionEstructurada_LITIID22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad, edad;
            string nombre;

            Console.Write("Ingresa la cantidad de personas a clasificar: ");

            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0)
            {
                Console.WriteLine("Número inválido. Por favor ingresa un valor numérico.");
                Console.Write("Ingresa la cantidad de personas a clasificar: ");
            }

            if (cantidad == 1)
            {
                Console.WriteLine("Ingresa el nombre de la persona ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la edad de la persona ");
                edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {Console.WriteLine(nombre, " eres mayor de edad");}

                else { Console.WriteLine(nombre, "Eres menor de edad"); }
            }
            
            
                List<string> nombreM = new List<string>();
                List<int> edadM = new List<int>();
                List<string> nombrem = new List<string>();
                List<int> edadm = new List<int>();

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.WriteLine("Ingresa el nombre de la persona " + i);
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa la edad de la persona " + i);

                while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
                {
                    Console.WriteLine("Número inválido. Por favor ingresa una edad numérica.");
                    Console.WriteLine("Ingresa la edad de la persona " + i);
                }

                if (edad >= 18)
                    {   nombreM.Add(nombre);
                        edadM.Add(edad);
                    }
                    else
                    {   nombrem.Add(nombre);
                        edadm.Add(edad);
                    }
                }
                Console.WriteLine("Lista de personas mayores");
                for (int i = 0; i < nombreM.Count; i++)
                {
                    Console.WriteLine(nombreM[i] + " - " + edadM[i]);
                 
                }
                Console.WriteLine("Lista de personas menores");
                for (int i = 0; i <  nombrem.Count; i++)
                {
                    Console.WriteLine(nombrem[i] + " - " + edadm[i]);

                }

            }
        }
        }
    
