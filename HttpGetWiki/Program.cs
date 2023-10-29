var client = new HttpClient();

for (var a = 'a'; a <= 'z'; a++)
{
    for (var b = 'a'; b <= 'z'; b++)
    {
        var response = await client.GetAsync($"https://ru.wikipedia.org/wiki/.{a}{b}");

        if (response.IsSuccessStatusCode)
        {
            File.WriteAllText($".\\WikiPages\\{a}{b}.html", await response.Content.ReadAsStringAsync());
        }
    }
}

