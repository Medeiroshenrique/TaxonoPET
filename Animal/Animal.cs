using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxonomiaPet.NovaPasta
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public int TempoDeVida { get; set; }
        public string? Habitat { get; set; }
        public string Genero { get; set; }
        public string Familia { get; set; }
        public string Especie { get; set; }

        public abstract void Respirar();
        public abstract void Locomover();
        public abstract void Correr();



    }
}
