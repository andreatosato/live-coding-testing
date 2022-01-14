using Xunit;

namespace Library.Tests
{
    public class FrullinoBuzzTest
    {
        [Fact]
        public void Count_100_Elements()
        {
            // Setup
            var testClass = new FrullinoBuzz();

            // Act
            var result = testClass.Output();

            // Verify
            Assert.Equal(100, result.Length);
        }

        [Fact]
        public void Frullino_3()
        {
            // Setup
            var testClass = new FrullinoBuzz();

            // Act
            var result = testClass.Output();

            // Verify
            Assert.Equal("Frullino", result[3]);
        }

        [Fact]
        public void Frullino_Multiple_3()
        {
            // Setup
            var testClass = new FrullinoBuzz();

            // Act
            var result = testClass.Output();

            // Verify
            for (int i = 0; i < 100; i++)
            {
                if ((i % 3) == 0 && (i % 5) != 0)
                    Assert.Equal("Frullino", result[i]);
            }
        }

        [Fact]
        public void Frullino_Multiple_5_Quarantadue()
        {
            // Setup
            var testClass = new FrullinoBuzz();

            // Act
            var result = testClass.Output();

            // Verify
            for (int i = 0; i < 100; i++)
            {
                if ((i % 5) == 0 && (i % 3) != 0)
                    Assert.Equal("42", result[i]);
            }
        }

        [Fact]
        public void Frullino_Multiple_3_And_Multiple_5()
        {
            // Setup
            var testClass = new FrullinoBuzz();

            // Act
            var result = testClass.Output();

            // Verify
            for (int i = 0; i < 100; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                    Assert.Equal("Frullino42", result[i]);
            }
        }

    }
}