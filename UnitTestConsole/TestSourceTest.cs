using SourceLib;
using System;
using Xunit;

namespace UnitTestConsole
{
    public class TestSourceTest
    {
        [Fact]
        public void Add_Positive_Test()
        {
            var source = new TestSource();
            Assert.Equal(3, source.Add(1, 2));
            Assert.Equal(5, source.Add(3, 2));
            Assert.NotEqual(8, source.Add(3, 4));
            Assert.NotEqual(10, source.Add(5, 4));
        }

        [Fact]
        public void Add_Negative_Test()
        {
            var source = new TestSource();
            Assert.Equal(-3, source.Add(-1, -2));
            Assert.Equal(-5, source.Add(-3, -2));
            Assert.NotEqual(-8, source.Add(-3, -4));
            Assert.NotEqual(-10, source.Add(-5, -4));
        }

        [Fact]
        public void Add_Positive_Negative_Test()
        {
            var source = new TestSource();
            Assert.Equal(1, source.Add(-1, 2));
            Assert.Equal(1, source.Add(3, -2));
            Assert.NotEqual(5, source.Add(3, -4));
            Assert.NotEqual(-1, source.Add(5, -4));
        }
    }
}
