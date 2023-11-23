string[] itens = File.ReadAllLines("data.txt");
int prioritySum = 0;

foreach (string item in itens)
{
    string firstCompartment = item.Substring(0, item.Length / 2);
    string lastCompartment = item.Substring(item.Length / 2);

    var i = firstCompartment.Intersect(lastCompartment).FirstOrDefault().ToString();

    if (Enum.TryParse(typeof(Priorities), i, out object priorityString))
    {
        prioritySum += (int)priorityString;
    }
    else
    {
        Console.WriteLine("Valor nao existente");
    }
    //prioritySum += (int)Enum.TryParse(i, out priority);
}

Console.WriteLine(prioritySum);

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
