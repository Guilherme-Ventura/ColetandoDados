using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColetarDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite nickname:");
            string linha = Console.ReadLine();

            ColetarDados executa = new ColetarDados();

            DadosInvocador dados = executa.BuscarRequisicao(linha);

            List<DadosPerfil> dados2 = executa.BuscarPerfil(dados.id);

            // string nickname = "Takato";
            Console.WriteLine("Nome: " + dados.name);
            Console.WriteLine($"level: {dados.summonerLevel}");
            Console.WriteLine($"Elo: {dados2[0].tier} {dados2[0].rank}");
            Console.WriteLine($"PDL: {dados2[0].leaguePoints}");
            Console.WriteLine($"Vitorias: {dados2[0].wins}");
            Console.WriteLine($"Derrotas: {dados2[0].losses}");


            Console.ReadKey();


        }
    }
}
