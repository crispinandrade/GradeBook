using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        // Integers
        [Fact]
        public void GetsInt()
        {
        var x = GetInt();
        Assert.Equal(1, x);

        SetInt(ref x, 22);
        Assert.Equal(22, x);
        
        }

        private void SetInt(ref int x, int val)
        {
            x = val;
        }

        private int GetInt(){
            return 1;
        }

        // Strings
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
        //Given
        string name = "Crispin";
        var upper = MakeUppercase(name);
        //When
        
        //Then
        Assert.Equal("CRISPIN", upper);
        Assert.Equal("Crispin", name);
        }

        private string MakeUppercase(string str)
        {
            return str.ToUpper();
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            // Act

            // Assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void PassByReference()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            // Act
            SetName(book1, "New Name");
            // Assert
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;
            // Act

            // Assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 1", book2.Name);
            Assert.Same(book1, book2);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}