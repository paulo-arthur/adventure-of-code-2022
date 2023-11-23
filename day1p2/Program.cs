string text_data = File.ReadAllText("data.txt");
string[] data = text_data.Split("\n");
List<List<int>> separetedData = new();
separetedData.Add(new List<int>());
List<int> sumData = new();

foreach (var item in data)
{
    if (!String.IsNullOrWhiteSpace(item))
    {
        separetedData[^1].Add(parseNum(item));
    }
    else
    {
        separetedData.Add(new List<int>());
    }
}

foreach (var a in separetedData)
{
    int sum = 0;
    foreach (var b in a)
    {
        sum += b;
    }

    sumData.Add(sum);
}

sumData.Sort();
Console.WriteLine(sumData[^1] + sumData[^2] + sumData[^3]);

static int parseNum(string n)
{
    try
    {
        return Convert.ToInt32(n);
    }
    catch
    {
        return 0;
    }
}