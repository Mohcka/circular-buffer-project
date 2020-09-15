using System;
using Xunit;

using CircularBuffer;

namespace CircularBuffer.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            CircularBuffer<int> cb = new CircularBuffer<int>(1);

            Assert.Equal(cb.doesSomething(), true);
        }

        [Fact]
        public void ShouldHaveSpecificSize()
        {
            const int size = 3;
            CircularBuffer<int> cb = new CircularBuffer<int>(size);

            Assert.Equal(cb.Size, size);
        }

        [Fact]
        public void isAtEnd()
        {
            CircularBuffer<int> cb = new CircularBuffer<int>(5);

            // Act
            cb.Insert(23);
            cb.Insert(23);
            cb.Insert(23);
            cb.Insert(23);
            // WriteInd now points to the end of
            // the buffer.

            // Assert
            Assert.True(cb.isAtEnd(cb.WriteInd));
        }

        [Fact]
        public void ShouldBeAbleToInsert()
        {
            // Arrange
            CircularBuffer<int> cb = new CircularBuffer<int>(5);

            // Act

            // 
            cb.Insert(42);


            // Assert
            Assert.Equal(0, 1);
        }

        [Fact]
        public void ShouldBeAbleToRemove()
        {
            // Arrange
            CircularBuffer<int>  cb = new CircularBuffer<int>(5);

            // Act


            // Assert
            Assert.True(false);
        }

        [Fact]
        public void ShouldBeAbleToReadValue()
        {
            // Arrange
            CircularBuffer<int> cb = new CircularBuffer<int>(5);

            // Act
            cb.Insert(76);

            // Assert

            Assert.Equal(0, 76);

        }

    }
}
