// See https://aka.ms/new-console-template for more information
using System.Net;
using static System.Net.Mime.MediaTypeNames;

LearningActivity31();
LearningActivity32();
LearningActivity33();
LearningActivity34();
LearningActivity35();

int interagerInput(string prompt)//This is to make sure that the entered number is a valid interager
{
    int a = 0;
    do
    {
        Console.WriteLine(prompt);
    }while (!(int.TryParse(Console.ReadLine(), out a)));
    return a;
}
void LearningActivity31()
{
    float temperature = 0F;
    do
    {
        Console.WriteLine("Please enter the temperature");
    }while (!(float.TryParse(Console.ReadLine(),out temperature)));
    int whatUnit = 0;
    do
    {
        whatUnit = interagerInput("What unit are you using?\n1 for celsius\n2 for fahrenheit");
    } while (whatUnit != 1 && whatUnit != 2);
    switch(whatUnit)
    {
        case 1:
            temperature = (temperature * (9F / 5F)) + 32F;
            Console.WriteLine("The temperature in fahrenheit is " + temperature);
            break;
        case 2:
            temperature = (temperature - 32F) * (5F / 9F);
            Console.WriteLine("The temperature in celsius is " + temperature);
            break;
    }
}
void LearningActivity32()
{
    string[] names = new string[14];
    int[] ages = new int[14];
    string[] wonders = {"the Great Wall of China","Petra","Colosseum","Chichen Itza","Machi Picchu","Taj Mahal","Christ the Redeemer"};
    for (int i = 0; i < wonders.Length; i++)
    {
        Console.WriteLine("the " + (i + 1) + " wonder of the world is " + wonders[i]);
    }
}
void LearningActivity33()
{
    Random rand = new Random();
    int[,] board = new int[3, 3];
    int[] weights = { 1, 4, 4 };
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < 3; j++)
        {
            int input;
            do
            {
                input = rand.Next(0, 3);
            } while (weights[input] == 0);
            board[i,j] = input;
            weights[input]--;
            if (board[i, j] == 1)
            {
                Console.Write("X  ");
            }
            else if (board[i, j] == 2)
            {
                Console.Write("O  ");
            }
            else
            {
                Console.Write("_  ");
            }
        }
    }
    int winner = 0;
    int heldInt;
    if (board[0, 0] == 1 || board[0,0] == 2)
    {
        heldInt = board[0,0];
        if (heldInt == board[0,1] && heldInt == board[0, 2])
        {
            winner = heldInt;
        }
        else if (heldInt == board[1,0] && heldInt == board[2,0])
        {
            winner = heldInt;
        }
        else if (heldInt == board[1,1] && heldInt == board[2, 2])
        {
            winner = heldInt;
        }
    }

    if (winner == 0 && (board[1, 0] == 1 || board[1, 0] == 2))
    {
        heldInt = board[1, 0];
        if (heldInt == board[1, 1] && heldInt == board[1, 2])
        {
            winner = heldInt;
        }
    }

    if (winner == 0 && (board[0,2] == 1 || board[0,2] == 1))
    {
        heldInt = board[0,2];
        if (heldInt == board[1,1] && heldInt == board[2,0])
        {
            winner=heldInt;
        }
        else if (heldInt == board[1,2] && heldInt == board[2,2])
        {
            winner=-heldInt;
        }
    }

    if (winner == 0 && (board[2,1] == 1 || board[2,1] == 2))
    {
        heldInt=board[2,1];
        if (heldInt == board[0,1] && heldInt==board[1,1])
        {
            winner = heldInt;
        }
        else if (heldInt == board[2,0] && heldInt == board[2,2])
        {
            winner=heldInt;
        }
    }
    Console.WriteLine();
    switch(winner)
    {
        case 1:
            Console.WriteLine("Player 1 wins");
            break;
        case 2:
            Console.WriteLine("Player 2 wins");
            break;
        default:
            Console.WriteLine("Nobody wins (HAHAHAHAHA LOSERS)");
            break;
    }
}

void LearningActivity34()
{
    int number;
    do
    {
        number = interagerInput("Please enter your age");
    } while (number > 9 && number < 51);
    Console.WriteLine("Took you long enough to enter " + number + "...");
    
}

void LearningActivity35()
{
    int[] highScores = { 1272700, 1271100, 1243000, 1218000, 1214300, 1210800, 1210400, 1206800, 1178400 };
    float average = 0F;
    for (int i = 0; i < highScores.Length; i++)
    {
        average += highScores[i];
    }
    average /= highScores.Length;
    Console.WriteLine("The average is: "+average);
}

