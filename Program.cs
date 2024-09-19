// See https://aka.ms/new-console-template for more information
bool badInput = true;

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
    if (whatUnit == 1)
    {
        temperature = (temperature * (9F / 5F)) + 32F;
        Console.WriteLine("The temperature in fahrenheit is " + temperature);
    }
    else
    {
        temperature = (temperature - 32F) * (5F / 9F);
        Console.WriteLine("The temperature in celsius is " + temperature);
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
    int[,] board = new int[3,3];
    for (int i = 0;i < 3;i++)
    {
        Console.WriteLine();
        for (int j = 0; j < 3;j++)
        {
            board[i,j] = rand.Next(0, 2);
            if (board[i,j] == 1)
            {
                Console.Write("X  ");
            }
            else if (board[i,j] == 2)
            {
                Console.Write("Y  ");
            }
            else
            {
                Console.Write("_  ");
            }
        }
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

