using GradeBook.Statistics;

namespace Gradebook;

public interface IBook
{
    string Name { get; }
    void AddGrade(double grade);
    Statistics GetStatistics();
}
