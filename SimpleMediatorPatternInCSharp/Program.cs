using System;
using System.Threading;

namespace SimpleMediatorPatternInCSharp
{
    /*
     A ideia principal desse padrão é a retirada da comunicação direta de duas entidades que devem comunicar mas não devem ter comunicação direta por questões de negócio.
    exemplos:
        * Aviões em decolagens com aviões em aterrizagens utilizam a torre de comandos para intermediar a comunicação
        * Debate de político em jornal, os candidatos são intermediados pelo jornalista.
        - O intermediador é responsável por manter a ordem na comunicação e gerenciar o tempo do discurso
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Debate Político!");

            var jornalistaCarinaFilho = new JornalistaIntermediator("Carina Filho",1);
            var candidatoCarlosMaia = new Candidato("Carlos Maia",jornalistaCarinaFilho);
            var candidatoPabloJuras = new Candidato("Pablo Juras", jornalistaCarinaFilho);

            Console.WriteLine(candidatoCarlosMaia.Fala("Boa noite!"));
            Console.WriteLine(candidatoPabloJuras.Fala("Boa noite!"));

            Console.WriteLine(candidatoCarlosMaia.Fala("Gostaria de agradecer a oportunidade de falar com todo o povo Brasileiro e perguntar o candidato sobre os planos para a saúde pública caso venha ser eleito."));
            Console.WriteLine(candidatoPabloJuras.Fala("Caro colega, eu agradeço sua preocupação com a saúde. Saiba que em meu governo reformaremos o modelo de atendimento do SUS e criaremos mais 1000 unidades de atendimento por todo nosso Brasil. Aproveito a oportunidade e devolvo-te a mesma pergunta."));


            Console.WriteLine(candidatoCarlosMaia.Fala());
            Console.WriteLine(candidatoPabloJuras.Fala("Caro candidato, devido a falta de sua resposta sobre a saúde fica claro a falta de preparo para Governar o nosso país."));
            
            //força a espera para o discurso ser interrompido pelo Intermediador
            Thread.Sleep(3000);

            Console.WriteLine(candidatoCarlosMaia.Fala("Os planos para a saúde serão repensados em momento de Governos."));
            
            Console.ReadKey();
        }
    }
}
