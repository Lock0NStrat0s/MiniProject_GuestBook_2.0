namespace MiniProject_GuestBook;

static class Methods
{
    public static void Welcome()
    {
        Console.WriteLine("Welcome to the guest book application!\n");
    }
    public static string GetName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    public static int GetNumberOfPeopleInParty()
    {
        int input = 0;
        bool isValid = false;
        do
        {
            Console.Write("How many people in your party? ");
            isValid = int.TryParse(Console.ReadLine(), out input);
        } while (!isValid || input < 1);

        return input;
    }

    public static bool AskToContinue()
    {
        Console.Write("Are there more guests (y/n)? ");
        return Console.ReadLine().ToLower() == "y" ? true : false;
    }

    public static (int totalGuests, List<string> guests) GetAllGuests()
    {
        int totalGuests = 0;
        List<string> guests = new List<string>();

        do
        {
            guests.Add(GetName());
            totalGuests += GetNumberOfPeopleInParty();
        } while (AskToContinue());

        return (totalGuests, guests);
    }

    public static void DisplayGuests(List<string> guests)
    {
        Console.WriteLine("Guests:");
        guests.ForEach(x => Console.WriteLine(x));
    }

    public static void DisplayGuestCount(int totalGuests)
    {
        Console.WriteLine($"Total number of guests: {totalGuests}");
    }
}
