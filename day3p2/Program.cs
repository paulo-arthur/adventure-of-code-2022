string[] itens = File.ReadAllLines("data.txt");
string[,] groups = new string[itens.Length / 3, 3];
char[] badges = new char[itens.Length / 3];
int sumOfBadges = 0;

for (int i = 0; i < itens.Length; i += 3)
{
    groups[i / 3, 0] = itens[i + 0];
    groups[i / 3, 1] = itens[i + 1];
    groups[i / 3, 2] = itens[i + 2];

    foreach (char l in itens[i])
    {
        if (itens[i + 1].Contains(l) && itens[i + 2].Contains(l))
        {
            badges[i / 3] = l;
        }
    }
}

foreach (var a in badges)
{
    if (Enum.TryParse(typeof(Priorities), a.ToString(), out object stringPriority))
    {
        sumOfBadges += (int)stringPriority;
    }
}

Console.WriteLine(sumOfBadges);

enum Priorities
{
    a = 1,
    b,
    c,
    d,
    e,
    f,
    g,
    h,
    i,
    j,
    k,
    l,
    m,
    n,
    o,
    p,
    q,
    r,
    s,
    t,
    u,
    v,
    w,
    x,
    y,
    z,
    A,
    B,
    C,
    D,
    E,
    F,
    G,
    H,
    I,
    J,
    K,
    L,
    M,
    N,
    O,
    P,
    Q,
    R,
    S,
    T,
    U,
    V,
    W,
    X,
    Y,
    Z
}
