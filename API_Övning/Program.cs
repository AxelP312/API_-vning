using System;
using RestSharp;
using Newtonsoft.Json;

namespace API_Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Skapar en klient som kan anropa en api
            RestClient klient = new RestClient("https://pokeapi.co/api/v2/");

            //Frågar om man 
            Console.WriteLine("Vilken pokemon vill du söka upp?");
            Console.Write("");
            string svarPokemon = Console.ReadLine();

            //Skapar ett objekt som kan fråga om information
            RestRequest förfrågan = new RestRequest("pokemon/" + svarPokemon);

            //Objekt som kan ta emot det svar man frågar efter. 
            IRestResponse svar = klient.Get(förfrågan);

            //String som innehåller det svar man frågar efter.
            string innehåll = svar.Content;

            
            // Console.WriteLine(innehåll);
            // Console.ReadLine();
            //kollar om det gick igenom

            //Skapar en pokemon efter informationen i JSON-filen samt klassen.
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(innehåll);

            System.Console.WriteLine(pokemon.height);
            Console.ReadLine();





        }
    }
}
