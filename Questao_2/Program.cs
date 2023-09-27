
class Program
{
    static void Main()
    {
        // Criar uma lista de nomes
        List<string> nomes = new List<string>
        {
            "João Silva",
            "Maria Santos",
            "Pedro Almeida",
            "Ana Souza"
        };

        // Iterar pela lista de nomes usando foreach
        Console.WriteLine("Nomes em maiúsculas:");
        foreach (string nome in nomes)
        {
            // Converter o nome para maiúsculas usando ToUpper()
            string nomeMaiusculo = nome.ToUpper();
            Console.WriteLine(nomeMaiusculo);
        }

        Console.WriteLine("\nPrimeira letra de cada nome:");
        foreach (string nome in nomes)
        {
            // Obter a primeira letra de cada nome usando Substring()
            string primeiraLetra = nome.Substring(0, 1);
            Console.WriteLine(primeiraLetra);
        }

        Console.WriteLine("\nNomes substituindo espaços por underscores:");
        foreach (string nome in nomes)
        {
            // Substituir espaços por underscores usando Replace()
            string nomeComUnderscores = nome.Replace(" ", "_");
            Console.WriteLine(nomeComUnderscores);
        }
    }
}