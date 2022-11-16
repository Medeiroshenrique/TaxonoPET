using TaxonomiaPet;
using TaxonomiaPet.NovaPasta;

for(int escolha=0;escolha!=4;) {
    Console.WriteLine("==================================================================");
    Console.WriteLine("    Bem-vindo ao TaxonoPet, qual animal vc quer conhecer?");
    Console.WriteLine("1-Sapo  2-Morcego  3-Rinoceronte 4-Sair");
    Console.WriteLine("==================================================================");
    escolha = int.Parse(Console.ReadLine());
    if (escolha == 1) {
        Sapo cururu = new Sapo("Sapo");
        Console.ForegroundColor = ConsoleColor.Green;
        cururu.Nome = "Sapo";
        cururu.TempoDeVida = 15;
        cururu.Familia = "Bufonidae";
        cururu.Habitat = "Onde houver umidade e água";
        cururu.Genero = "Rhinella";
        cururu.Especie = "Bufo spinosus";
        Console.WriteLine($"Nome: {cururu.Nome}");
        Console.WriteLine($"Tempo de Vida: {cururu.TempoDeVida} anos");
        Console.WriteLine($"Familia: {cururu.Familia}");
        Console.WriteLine($"Habitat: {cururu.Habitat}");
        Console.WriteLine($"Gênero: {cururu.Genero}");
        Console.WriteLine($"Especie: {cururu.Especie}");
        cururu.Respirar();
        cururu.Correr();
        cururu.Locomover();
        Console.WriteLine();
        Console.ResetColor();
    }else if(escolha== 2) {
        Console.ForegroundColor = ConsoleColor.Red;
        Morcego bat = new Morcego("Morcego");
        bat.TempoDeVida = 30;
        bat.Familia = "Noctilionidae";
        bat.Habitat = "grutas e espaços ocos dentro de árvores";
        bat.Genero = "Scrotifera";
        bat.Especie = "Tadarida brasiliensis";
        Console.WriteLine($"Nome: {bat.Nome}");
        Console.WriteLine($"Tempo de Vida: {bat.TempoDeVida} anos");
        Console.WriteLine($"Família: {bat.Familia}");
        Console.WriteLine($"Habitat: {bat.Habitat}");
        Console.WriteLine($"Gênero: {bat.Genero}");
        Console.WriteLine($"Espécie: {bat.Especie}");
        bat.Respirar();
        bat.Correr();
        bat.Locomover();
        Console.ResetColor();
        Console.WriteLine();
    }else if (escolha == 3) {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Rinoceronte rino = new Rinoceronte("Rinoceronte"); 
        rino.TempoDeVida = 50;
        rino.Familia = "Rhinocerontidae";
        rino.Habitat = "Savanas e florestas com água";
        rino.Genero = "Rinoceronte-branco, Rinoceronte-negro, Rinoceronte-de-sumatra, Rinoceronte-de-java e Rinoceronte-indiano  ";
        rino.Especie = "Ceratotherium simum, Diceros bicornis, Dicerorhinus sumatrensis, Rhinoceros sondaicus e Rhinoceros unicornis";
        Console.WriteLine($"Nome: {rino.Nome}");
        Console.WriteLine($"Tempo de Vida: {rino.TempoDeVida} anos");
        Console.WriteLine($"Família: {rino.Familia}");
        Console.WriteLine($"Habitat: {rino.Habitat}");
        Console.WriteLine($"Gênero: {rino.Genero}");
        Console.WriteLine($"Espécie: {rino.Especie}");
        rino.Respirar();
        rino.Correr();
        rino.Locomover();
        Console.ResetColor();
    }
}





