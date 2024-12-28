namespace ConsoleApp1
{
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Seasons
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    enum Colors
    {
        Red,
        Green,
        Blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region Q2
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string userInput = Console.ReadLine();

            //if (Enum.TryParse(userInput, true, out Seasons selectedSeason))
            //{
            //    switch (selectedSeason)
            //    {
            //        case Seasons.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Seasons.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Seasons.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Seasons.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}
            #endregion
            #region Q3
            //Permissions userPermissions = Permissions.None;

            //userPermissions |= Permissions.Read;   
            //userPermissions |= Permissions.Write; 
            //Console.WriteLine($"Current Permissions: {userPermissions}");
            //Console.WriteLine($"Has Read Permission: {userPermissions.HasFlag(Permissions.Read)}");
            //Console.WriteLine($"Has Execute Permission: {userPermissions.HasFlag(Permissions.Execute)}");
            //userPermissions &= ~Permissions.Read;
            //Console.WriteLine($"Permissions after removing Read: {userPermissions}");
            //Console.WriteLine($"Has Read Permission after removal: {userPermissions.HasFlag(Permissions.Read)}");
            #endregion
            #region Q4
            //Console.WriteLine("Enter a color name (e.g., Red, Green, Blue):");
            //string userInput = Console.ReadLine();

            //if (Enum.TryParse(userInput, true, out Colors inputColor))
            //{
            //    if (inputColor == Colors.Red || inputColor == Colors.Green || inputColor == Colors.Blue)
            //    {
            //        Console.WriteLine($"{inputColor} is a primary color.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{userInput} is not a valid primary color.");
            //}
            #endregion
        }
    }
}
