

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);  // väärtus 0-6

switch (weekDay)    // väärtus, mida kontrollitakse
{
    case 0:     //0 võrdub if(weekday == 0)
        Console.WriteLine("It's Sunday!");
        break;
        case 1:
        Console.WriteLine("It's Monday!");
        break;
        case 2:
        Console.WriteLine("Its Tuesday!");
        break;
        case 3:
        Console.WriteLine("Its Wednesday!");
        break;
        case 4:
        Console.WriteLine("Its Thursday!");
        break;
        case 5:
        Console.WriteLine("Its Friday!");
        break;
        case 6:
        Console.WriteLine("Its Saturday!");
        break;
        default:
        Console.WriteLine("Oops, kalender läks katki");
        break;
}
Console.WriteLine("Have a nice day!");