using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxonomiaPet.NovaPasta
{
    public class Morcego:Animal
    {
        public Morcego(string Nome) { this.Nome = "Morcego"; }
        public override void Correr()
        {
            Console.WriteLine("Pra quê correr se posso voar?");
        }

        public override void Locomover()
        {
            Console.WriteLine("Usando duas asas consigo voar a 160 quilômetros por hora");
        }

        public override void Respirar()
        {
            Console.WriteLine("Respiro usando as narinas, posso passar até uma hora sem respirar se hibernar");
        }

    }
}
