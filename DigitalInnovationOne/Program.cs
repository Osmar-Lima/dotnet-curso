using System; // pacote do proprio dotnet

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 5;
            string nome= "Osmar";
            string curso = "C#";
            
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Ola {nome} Bem-Vindo ao Curso de {curso} {i +1} com a Digital Innovation One");
            }

        }
    }
}
