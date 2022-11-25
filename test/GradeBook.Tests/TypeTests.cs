using Gradebook;

namespace GradeBook.Tests;

public class TypeTests
{

    [Fact]
    public void Tests1()
    {
        var x = GetInt();
        SetInt(ref x);

        Assert.Equal(42, x);
    }

    private int GetInt()
    {
        return 3;
    }

    private void SetInt(ref int x)
    {
        x = 42;
    }

    [Fact]
    public void StringBehavesLikeValues()
    {
        string name = "Sajidh";
        var upper = MakeUpperCase(name);

        Assert.Equal("Sajidh", name);
        Assert.Equal("SAJIDH", upper);
    }

    private string MakeUpperCase(string name)
    {
        return name.ToUpper();
    }

    [Fact]
    public void CanSetNameFromReference()
    {
        //arrange
        var book1 = GetBook("Book 1");
        SetName(book1, "New Name");

        Assert.Equal("New Name", book1.Name);
    }

    private void SetName(InMemoryBook book, string name)
    {
        book.Name = name;
    }

    [Fact]
    public void BookCalculateAnAverageGrade()
    {
        //arrange
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        //assert
        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1, book2);
    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
        //arrange
        var book1 = GetBook("Book 1");
        var book2 = book1;

        //assert
        Assert.Same(book1, book2);
        Assert.True(Object.ReferenceEquals(book1, book2));
    }



    InMemoryBook GetBook(string name)
    {
        return new InMemoryBook(name);
    }
}