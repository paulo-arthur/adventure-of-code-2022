string buffer = File.ReadAllText("data.txt");
int n = 14;

for (int charPosition = 0; charPosition < buffer.Length - n - 1; charPosition++)
{
    string packet = "";
    for (int i = 0; i != n; i++)
    {
        packet += buffer[charPosition + i].ToString();
    }


    List<char> chrs = new List<char>();
    foreach (var c in packet)
    {
        if (!chrs.Contains(c))
        {
            chrs.Add(c);
        }

        if (chrs.Count() == n)
        {
            Console.WriteLine(charPosition + n);
            //Console.WriteLine(packet);
        }
    }
}