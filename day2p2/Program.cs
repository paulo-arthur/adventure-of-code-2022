string[] turns = File.ReadAllLines("data.txt");
int totalPontuation = 0;

/*
A - Pedra 1
B - Papel 2
C - Tesoura 3

X - Perde
Y - Empate
Z - Ganha

*/

foreach (var turn in turns)
{
    int pontuation = 0;
    switch (turn[0])
    {
        case 'A': //PEDRA
            switch (turn[2])
            {
                case 'X': //PERDE
                    pontuation += 0 + 3;
                    break;
                case 'Y': //EMPATE
                    pontuation += 3 + 1;
                    break;
                case 'Z': //GANHA
                    pontuation += 6 + 2;
                    break;
                default:
                    break;
            }
            break;
        case 'B'://PAPEL
            switch (turn[2])
            {
                case 'X'://PERDE
                    pontuation += 0 + 1;
                    break;
                case 'Y'://EMPATE
                    pontuation += 3 + 2;
                    break;
                case 'Z'://GANHA
                    pontuation += 6 + 3;
                    break;
                default:
                    break;
            }
            break;
        case 'C'://TESOURA
            switch (turn[2])
            {
                case 'X'://PERDE
                    pontuation += 0 + 2;
                    break;
                case 'Y'://EMPATA
                    pontuation += 3 + 3;
                    break;
                case 'Z'://GANHA
                    pontuation += 6 + 1;
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