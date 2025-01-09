using System.Net.Http.Json;
HttpClient client = new();
client.BaseAddress = new("https://digi-api.com/api/v1/digimon/");
HttpResponseMessage response = client.GetAsync("29/").Result;
Digimon d = response.Content.ReadFromJsonAsync<Digimon>().Result;

Console.WriteLine($"Guess this digimon's name. (shows picture from website)");
string answer = Console.ReadLine();
while (answer != d.name)
{
    Console.WriteLine("Wrong! Try again.");
    answer = Console.ReadLine();
}
Console.WriteLine("Congrats! You guessed right!");

Console.WriteLine($"Name: {d.name} || ID: {d.id}");
Console.ReadLine();

// using System.Text.Json;
// using System.Xml.XPath;
// string digi = response.Content.ReadAsStringAsync().Result;
// Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content.ReadAsStringAsync().Result);
// File.WriteAllText("digi.json", digi);