Console.CursorVisible = false;
Console.Title = "Wedding Day Reminder aka The End of Your Freedom Reminder";

string remainingDays = "DAYS & TIME REMAINING TILL YOUR UMAR QEYD ON 27-JAN-2023";
DateTime nikkahDateTimeLmao = new DateTime(2023, 1, 27, 15, 30, 0);
List<string> finalMessages = new List<string>{ "Poor you hehe...", "jk jk mubarak ho lmao" };

CreateAndRemoveCurtain(20, true);
CreateFallingTextAnimation(remainingDays, nikkahDateTimeLmao, finalMessages, 1);

Console.Read();

//Methods
static void CreateAndRemoveCurtain(int speedInMs = 15, bool createCurtain = true)
{
    int x = 1;
    do
    {
        for (int y = 1; y < 24; y++)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.Write("░▒▓▒░");
            Console.SetCursorPosition(81 - x, y);
            Console.Write("░▒▓▒░");
        }

        x = x + 5;
    } while (x < 41);

    if (createCurtain)
    {
        for (x = 41; x > 0; x--)
        {
            for (int y = 1; y < 24; y++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                Console.SetCursorPosition(85 - x, y);
                Console.Write(" ");
            }
            Thread.Sleep(speedInMs);
        }
    }
}

static void CreateFallingTextAnimation(string remainingDaysHeader, DateTime daysAndTimeRemaining, List<string> finalMessages, int speedInMs = 5)
{
    //Header
    Console.SetCursorPosition(12, 40);
    for (int i = 0; i < remainingDaysHeader.Length; i++)
    {
        for (int j = 12; j < 20; j++)
        {
            Console.SetCursorPosition(12 + i, j);
            Console.Write(remainingDaysHeader[i]);
            Console.SetCursorPosition(12 + i, j - 1);
            Console.Write(" ");
            Thread.Sleep(speedInMs);
        }
    }

    //Wait 2 seconds
    Thread.Sleep(2000);

    //Days & Time Remaining
    TimeSpan daysAndTimeRemainingTS = daysAndTimeRemaining - DateTime.Now;
    string daysAndTimeRemainingStr = "";
    daysAndTimeRemainingStr = daysAndTimeRemainingTS.Days.ToString() + " Day(s), " +
                              daysAndTimeRemainingTS.Hours.ToString() + " Hours(s), " +
                              daysAndTimeRemainingTS.Minutes.ToString() + " Minutes(s), " +
                              daysAndTimeRemainingTS.Seconds.ToString() + " Seconds(s)";

    Console.SetCursorPosition(17, 50);
    for (int i = 0; i < daysAndTimeRemainingStr.Length; i++)
    {
        for (int j = 24; j < 32; j++)
        {
            Console.SetCursorPosition(17 + i, j);
            Console.Write(daysAndTimeRemainingStr[i]);
            Console.SetCursorPosition(17 + i, j - 1);
            Console.Write(" ");

            Thread.Sleep(speedInMs);
        }
    }

    //Wait 3 seconds before final message
    Thread.Sleep(500);
    Console.SetCursorPosition(34, 33);
    Console.Write(finalMessages[0]);
    Thread.Sleep(2000);
    Console.SetCursorPosition(30, 34);
    Console.Write(finalMessages[1]);
}