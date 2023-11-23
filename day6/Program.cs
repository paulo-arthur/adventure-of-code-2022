string buffer = File.ReadAllText("data.txt");

for (int charPosition = 0; charPosition < buffer.Length - 3; charPosition++)
{
    string packet = buffer[charPosition].ToString() + buffer[charPosition + 1].ToString() + buffer[charPosition + 2].ToString() + buffer[charPosition + 3].ToString();
    List<char> chrs = new List<char>();
    foreach (var c in packet)
    {
        if (!chrs.Contains(c))
        {
            chrs.Add(c);
        }

        if (chrs.Count() == 4)
        {
            Console.WriteLine(charPosition);
            Console.WriteLine(packet);
        }
    }
}