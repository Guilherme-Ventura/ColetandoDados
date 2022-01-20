using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColetarDados
{
    public class ColetarDados
    {
        public DadosInvocador BuscarRequisicao(string nickname)
        {
            var client = new RestClient("https://br1.api.riotgames.com/lol/summoner/v4/summoners/by-name/"+nickname);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-Riot-Token", "RGAPI-9884381c-ff93-4f6d-804a-39399c16feca");
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            DadosInvocador saida = JsonConvert.DeserializeObject<DadosInvocador>(response.Content);

            return saida;
        }
        public List<DadosPerfil> BuscarPerfil(string id)
        {
            var client = new RestClient("https://br1.api.riotgames.com/lol/league/v4/entries/by-summoner/"+id);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-Riot-Token", "RGAPI-9884381c-ff93-4f6d-804a-39399c16feca");
            IRestResponse response = client.Execute(request);

            List<DadosPerfil> saida = JsonConvert.DeserializeObject<List<DadosPerfil>>(response.Content);

            return saida;
        }
    }
}
