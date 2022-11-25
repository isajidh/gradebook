using GradeBook.Statistics;

namespace Gradebook;

public class InMemoryBook : Book
{
    public InMemoryBook(string name) : base(name)
    {
        grades = new List<double>();
        Name = name;
    }

    public override void AddGrade(double grade)
    {
        if (grade <= 100 && grade >= 0)
        {
            grades.Add(grade);
        }
        else
        {
            throw new ArgumentException($"Invalid {nameof(grade)}");
        }
    }
    // public void AddGrade(char Letter)
    // {
    //     switch (Letter)
    //     {
    //         case var d when d >= 90:
    //             Letter = 'A';
    //             break;

    //         case var d when d >= 80:
    //             Letter = 'B';
    //             break;

    //         case var d when d >= 70:
    //             Letter = 'C';
    //             break;

    //         case var d when d >= 60:
    //             Letter = 'D';
    //             break;

    //         default:
    //             Letter = 'F';
    //             break;
    //     }
    // }
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

    private List<double> grades;
    private string name;
    public const string CATEGORY = "Science";
}
