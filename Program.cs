using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca su nombre de usuario");
            string usuario;
            usuario = Console.ReadLine();
            string pass;


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduzca su password");
                pass = Console.ReadLine();
                if (usuario == pass)
                {
                    Console.WriteLine("Bienvenido " + usuario);
                    Console.ReadLine();
                        break;
                }
                else
                {
                    Console.WriteLine("Contraseña Incorrecta");
                    if (i == 2)
                    {
                        Console.WriteLine("Usuario Bloqueado");
                        Console.ReadLine();
                        
                    }
                }
            
            }



        }
    }
}
