string[] procedureTxt = File.ReadAllLines("procedure.txt");
string[] cratesTxt = File.ReadAllLines("crates.txt");

int[,] procedure = new int[procedureTxt.Length, 3];
List<string>[] crates = new List<string>[cratesTxt[^1].Split(" ").Length];

for (int c = 0; c < crates.Length; c++)
{
    crates[c] = new List<string>();
}

for (int p = 0; p < procedureTxt.Length; p++)
{
    procedure[p, 0] = Convert.ToInt32(procedureTxt[p].Split(" ")[1]);
    procedure[p, 1] = Convert.ToInt32(procedureTxt[p].Split(" ")[3]) - 1;
    procedure[p, 2] = Convert.ToInt32(procedureTxt[p].Split(" ")[5]) - 1;
}

for (int line = 0; line < cratesTxt.Length; line++)
{
    for (int c = 1; c < 1 + 4 * cratesTxt[^1].Split(" ").Length; c += 4)
    {
        string item = cratesTxt[line][c].ToString();
        if (!String.IsNullOrWhiteSpace(item))
        {
            crates[(c - 1) / 4].Add(item);
        }
    }
}

for (int proc = 0; proc < procedure.GetLength(0); proc++)
{
    List<string> temp = new List<string>();
    for (int i = 0; i < procedure[proc, 0]; i++)
    {
        PrintCrates(crates);
        Console.WriteLine($"Tentando mover {procedure[proc, 0]} elementos do {procedure[proc, 1]} para o {procedure[proc, 2]} | elemento {crates[procedure[proc, 1]][0]}");
        temp.Add(crates[procedure[proc, 1]][0]);
        crates[procedure[proc, 1]] = RemoveAtTop(crates[procedure[proc, 1]]);
    }
    crates[procedure[proc, 2]] = temp.Concat(crates[procedure[proc, 2]]).ToList();
}

PrintCrates(crates);

static List<string> AddAtTop(List<string> s, string i)
{
    s.Reverse();
    s.Add(i);
    s.Reverse();
    return s;
}

static List<string> RemoveAtTop(List<string> s)
{
    s.RemoveAt(0);
    return s;
}

static void PrintCrates(List<string>[] a)
{
    for (int p = 0; p < a.Length; p++)
    {
        for (int q = 0; q < a[p].Count(); q++)
        {
            //Console.Write($"({p}-{q})");
            Console.Write(a[p][q]);
        }
        Console.WriteLine();
    }
}