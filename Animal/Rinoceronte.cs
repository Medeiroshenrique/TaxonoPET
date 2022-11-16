using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxonomiaPet.NovaPasta
{
    public class Rinoceronte : Animal
    {
        public Rinoceronte(string Nome) { this.Nome = "Rinoceronte"; }
        public override void Correr()
        {
            Console.WriteLine("Posso correr a 45 quilômetros por hora");
        }

        public override void Locomover()
        {
            Console.WriteLine("Corro usando quatro patas, distribuindo meus 2300 quilos");
        }

        public override void Respirar()
        {
            Console.WriteLine("Respiro pelos meus pulmões");
        }
    }
}
