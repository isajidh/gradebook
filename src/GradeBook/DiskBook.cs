using Gradebook;
using GradeBook.Statistics;

public class DiskBook : Book
{
    public DiskBook(string name) : base(name)
    {
    }
    public override void AddGrade(double grade)
    {
        //use this object and in the end of the curly brace dispose it
        using (var writer = File.AppendText($"./Grades/{Name}.txt"))
        {
            writer.WriteLine(grade);
        }
    }
    public override Statistics GetStatistics()
    {
        var result = new Statistics();
        using (var reader = File.OpenText($"./Grades/{Name}.txt"))
        {
            var line = reader.ReadLine();
            while (line != null)
            {
                result.Add(double.Parse(line));
                line = reader.ReadLine();
            }
        }
        return result;
    }
}