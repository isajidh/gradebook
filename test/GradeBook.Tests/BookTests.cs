using Gradebook;

namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void BookCalculateAnAverageGrade()
    {
        //arrange
        var book = new InMemoryBook("");


        //act
        var result = book.GetStatistics();


        //assert
        Assert.Equal(12.57, result.High, 2);
        Assert.Equal(12.55, result.Low, 2);
        Assert.Equal(12.56, result.Average, 2);
        Assert.Equal(37.68, result.Total, 2);
        Assert.Equal('F', result.Letter);
    }
}