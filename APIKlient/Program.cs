using System.Net.Http.Json;
using System.Text.Json;
using System.Xml.XPath;

HttpClient client = new();

client.BaseAddress = new("https://pokeapi.co/api/v2/"); //hämtar info

HttpResponseMessage response = client.GetAsync("pokemon/snorlax").Result;

string snorlax = response.Content.ReadAsStringAsync().Result;

Pokemon p = JsonSerializer.Deserialize<Pokemon>(snorlax); //från text till objekt

// slippa två rader över här
// Pokemon p = response.Content.ReadFromJsonAsync<Pokemon>.Result;

Console.WriteLine(p.weight);
// File.WriteAllText("snorlax.json", snorlax); //skapa json fil

Console.ReadLine();