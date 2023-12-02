using Advanced_c_;
public class Program
{
    private static void Main(string[] args)
    {
        Event info = new Event("Corporate Event", "FX Event Centre", Eventint.CorporateEvent);
        info.Printinfo();

        Console.WriteLine("\\\\\\\\\\\\");

        Event info1 = new Event();
        info1.Eventtype = "Wedding Ceremony";
        info1.Venue = "B&G Event Cemtre";
        info1.eventint = Eventint.Weddings;
        info1.Printinfo();

        Console.WriteLine("\\\\\\\\\\\\");

        Event info2 = new Event
        {
            Eventtype = "Birthday Celebration",
            Venue = "Adex Event Hall",
            eventint = Eventint.Birthdays
           
        };
        info2.Printinfo();

        string[] values = (string[])Enum.GetNames(typeof(Eventint));
        foreach (string value in values)
        {
            Console.WriteLine(value);
        }

        int[] even = (int[])Enum.GetValues(typeof(Eventint));
        foreach (int value in even)
        {
            Console.WriteLine(value);
        }
    }
}