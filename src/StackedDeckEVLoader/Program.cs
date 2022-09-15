using System.Text.Json;

var uri = "https://poe.ninja/api/data/itemoverview?league=Kalandra&type=DivinationCard";
using var client = new HttpClient();

var resp = await client.GetAsync(uri);
var contentStream = await resp.Content.ReadAsStreamAsync();
var data = await JsonSerializer.DeserializeAsync<DeckData>(contentStream);

if (data == null)
{
    throw new NullReferenceException(nameof(data));
}

var path = Path.GetFullPath("output.txt");
Console.WriteLine($"Writing > {path}");

using var file = File.Open(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
using var writer = new StreamWriter(file);
writer.AutoFlush = true;

foreach (var line in data.lines.OrderBy(l => l.name))
{
    var output = $"{line.name}\t{line.chaosValue}";
    Console.WriteLine(output);
    await writer.WriteLineAsync(output);
}

Console.WriteLine();
Console.WriteLine($"Finished writing to {path}");
Console.WriteLine("Execution complete, press enter to finish");
Console.ReadLine();