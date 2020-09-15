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
    }
}
