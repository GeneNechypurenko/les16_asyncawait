using les16_asyncawait;
using Newtonsoft.Json;

static async void GetData()
{
    double sum = GiveMoney();

    string url = @"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";
    HttpClient client = new HttpClient();
    HttpResponseMessage responce = await client.GetAsync(new Uri(url));

    if (responce.IsSuccessStatusCode)
    {
        string jsonContent = await responce.Content.ReadAsStringAsync();
        List<Currency> data = JsonConvert.DeserializeObject<List<Currency>>(jsonContent);
        foreach (Currency currency in data)
        {
            if (currency.r030 == 840.ToString())
            {
                Console.WriteLine(sum / currency.rate);
            }

            //Console.WriteLine($"{currency.r030} {currency.cc} {currency.rate}");
        }
    }
}
static double GiveMoney()
{
    Console.WriteLine("in UAH");
    return Convert.ToDouble(Console.ReadLine());
}

GetData();
Console.ReadLine();