using System.Net.Http.Json;
// using System.Text.Json;
// using System.Xml.XPath;

HttpClient client = new();
client.BaseAddress = new("https://digi-api.com/api/v1/digimon/");
HttpResponseMessage response = client.GetAsync("29/").Result;

Digimon d = response.Content.ReadFromJsonAsync<Digimon>().Result;
// string digi = response.Content.ReadAsStringAsync().Result;
// Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content.ReadAsStringAsync().Result);

// File.WriteAllText("digi.json", digi);

Console.WriteLine(d.name);

Console.ReadLine();