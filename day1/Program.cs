string text_data = File.ReadAllText("data.txt");
string[] data = text_data.Split("\n");
List<List<int>> separetedData = new();

foreach (var item in data)
{
    if (!String.IsNullOrWhiteSpace(item))
    {
        if (separetedData.Count == 0)
        {
            separetedData.Add(new List<int>());
            separetedData[^1].Add(parseNum(item));
        }
        else
        {
            separetedData[^1].Add(parseNum(item));
        }
    }
    else
    {
        separetedData.Add(new List<int>());
    }
}

int biggestSum = 0;

foreach (var a in separetedData)
{
    int sum = 0;
    foreach (var b in a)
    {
        sum += b;
    }

    if (sum > biggestSum)
    {
        biggestSum = sum;
    }
}

Console.WriteLine(biggestSum);

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