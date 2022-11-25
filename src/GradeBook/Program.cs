using Gradebook;

public class Program
{
    private static void Main(string[] args)
    {
        var done = false;
        IBook book = new DiskBook("New Book");
        done = EnterGrades(book);
        var stats = book.GetStatistics();

        System.Console.WriteLine($"Total is : {stats.Total}");
        System.Console.WriteLine($"Average is : {stats.Average:N2}");
        System.Console.WriteLine($"lowest grade is : {stats.Low:N2}");
        System.Console.WriteLine($"Hghest grade is : {stats.High:N2}");
        System.Console.WriteLine($"Average grade is : {stats.Letter:N2}");
    }

    private static bool EnterGrades(IBook book)
    {
        bool done = false;
        while (!done)
        {
            System.Console.WriteLine("Enter a grade or 'q' to guit");
            var input = Console.ReadLine();
            if (input == "q")
            {
                done = true;
                continue;
            }
            try
            {
                var grade = Double.Parse(input);
                book.AddGrade(grade);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return done;
    }
}