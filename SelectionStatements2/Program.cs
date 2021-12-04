
Console.WriteLine("Choose a school subject");
string userSubject = Console.ReadLine();

switch (userSubject)
{
    case "English":
        Console.WriteLine("Welcome to English");
        break;
    case "Math":
        Console.WriteLine("Welcome to Math");
        break;
    case "Science":
        Console.WriteLine("Welcome to Science");
        break;
    case "History":
        Console.WriteLine("Welcome to History");
        break;

    default:
        Console.WriteLine($"We don't offer {userSubject} here");
        break;
}