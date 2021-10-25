using FluentAssertions;
using NUnit.Framework;
using RiderCategoryAttributeIssue.Environment;

namespace RiderCategoryAttributeIssue
{
    [Environment.Prod]
    [Environment.Qa]
    [Environment.Dev]
    public class NUnit_Test : IntegrationTestBase
    {
        public NUnit_Test(Stage stage) : base(stage)
        {
        }

        [Test]
        public void Should_Work_With_Rider_As_Well()
        {
            1.Should().Be(1);
        }
    }    
}
