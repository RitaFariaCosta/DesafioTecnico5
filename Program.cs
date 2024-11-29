using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnico3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem p1 = new Personagem("Inej Ghafa", 20);
            Personagem p2 = new Personagem("JJ Maybank", 18);

            Console.WriteLine("\nDigite uma característica para a personagem 1: ");
            p1.adicionarCaracteristicas(Console.ReadLine());

            Console.WriteLine("\nDigite 1 caso você queira adicionar mais características para a personagem e outro número caso você não queira: ");
            int numero1 = int.Parse(Console.ReadLine());
            if(numero1 == 1)
            {
                Console.WriteLine("\nDigite uma característica: ");
                p1.adicionarCaracteristicas(Console.ReadLine());
                p1.mostrarDados();
            }
            else
            {
                p1.mostrarDados();
            }

            Console.WriteLine("\nDigite uma característica para o personagem 2: ");
            p2.adicionarCaracteristicas(Console.ReadLine());

            Console.WriteLine("\nDigite 1 caso você queira adicionar mais características para o personagem e outro número caso você não queira: ");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero2 == 1)
            {
                Console.WriteLine("\nDigite uma característica: ");
                p2.adicionarCaracteristicas(Console.ReadLine());
                p2.mostrarDados();
            }
            else
            {
                p2.mostrarDados();
            }
            Console.ReadLine();

        }
    }
}
