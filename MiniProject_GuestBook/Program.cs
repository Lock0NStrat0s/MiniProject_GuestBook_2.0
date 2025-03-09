namespace MiniProject_GuestBook;

internal class Program
{
    static void Main(string[] args)
    {
        Methods.Welcome();
        var (totalGuests, guests) = Methods.GetAllGuests();
        Methods.DisplayGuests(guests);
        Methods.DisplayGuestCount(totalGuests);
    }
}
