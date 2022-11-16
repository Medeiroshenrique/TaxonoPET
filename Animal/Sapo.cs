using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxonomiaPet.NovaPasta
{
    public class Sapo : Animal
    {
        public Sapo(string Nome) { this.Nome = "Sapo"; }
        public override void  Respirar(){
            Console.WriteLine("Respiro usando a pele (respiracao cutânea)");
        }
        public override void Locomover()
        {
            Console.WriteLine("Me movo pulando, tenho quatro patas das quais duas me dão impulso para pular");
        }

        public override void Correr()
        {
            Console.WriteLine("Falho miseravelmente, mas tento correr");
        }


    }
}
