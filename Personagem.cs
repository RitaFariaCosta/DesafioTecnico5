using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnico3
{
    internal class Personagem
    {
        public string nome { get; set; }
        public int idade { get; set; }
        List<string> caracteristicas = new List<string>();

        public Personagem(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public void adicionarCaracteristicas(string carac)
        {
            caracteristicas.Add(carac);
        }
        public void mostrarDados()
        {
            Console.WriteLine($"\nNome do personagem: {nome}");
            Console.WriteLine($"Idade do personagem: {idade}");
            foreach(string carac in caracteristicas)
            {
                Console.WriteLine($"Características: {carac}");
            }
        }

    }
}
