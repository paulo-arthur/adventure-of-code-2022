string[] turns = File.ReadAllLines("data.txt");
int totalPontuation = 0;

/*
A X - Pedra 1
B Y - Papel 2
C Z - Tesoura 3
*/

foreach (var turn in turns)
{
    int pontuation = 0;
    switch (turn[0])
    {
        case 'A': //PEDRA
            switch (turn[2])
            {
                case 'X': //PEDRA
                    pontuation += 3 + 1;
                    break;
                case 'Y': //PAPEL
                    pontuation += 6 + 2;
                    break;
                case 'Z': //TESOURA
                    pontuation += 0 + 3;
                    break;
                default:
                    break;
            }
            break;
        case 'B'://PAPEL
            switch (turn[2])
            {
                case 'X'://PEDRA
                    pontuation += 0 + 1;
                    break;
                case 'Y'://PAPEL
                    pontuation += 3 + 2;
                    break;
                case 'Z'://TESOURA
                    pontuation += 6 + 3;
                    break;
                default:
                    break;
            }
            break;
        case 'C'://TESOURA
            switch (turn[2])
            {
                case 'X'://PEDRA
                    pontuation += 6 + 1;
                    break;
                case 'Y'://PAPEL
                    pontuation += 0 + 2;
                    break;
                case 'Z'://TESOURA
                    pontuation += 3 + 3;
                    break;
                default:
                    break;
            }
            break;
        default:
            break;
    }

    totalPontuation += pontuation;
}

Console.WriteLine(totalPontuation);