string[] txtRanges = File.ReadAllLines("data.txt");
int[,] ranges = new int[txtRanges.Length, 4];
int numOfPairsThatRangeFullyContainsTheOther = 0;

for (int r = 0; r < txtRanges.Length; r++)
{
    ranges[r, 0] = Convert.ToInt32(txtRanges[r].Split("-")[0]);
    ranges[r, 1] = Convert.ToInt32(txtRanges[r].Split("-")[1].Split(",")[0]);
    ranges[r, 2] = Convert.ToInt32(txtRanges[r].Split("-")[1].Split(",")[1]);
    ranges[r, 3] = Convert.ToInt32(txtRanges[r].Split("-")[2]);
}

for (int i = 0; i < ranges.GetLength(0); i++)
{
    if ((ranges[i, 0] <= ranges[i, 2] && ranges[i, 1] >= ranges[i, 3]) || (ranges[i, 2] <= ranges[i, 0] && ranges[i, 3] >= ranges[i, 1]))
    {
        numOfPairsThatRangeFullyContainsTheOther++;
    }
}

Console.WriteLine(numOfPairsThatRangeFullyContainsTheOther);