using System;
using Xunit;

namespace Logging.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(5, Add(2, 2));
        }
        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
