using NUnit.Framework;

namespace RiderCategoryAttributeIssue.Environment
{
    public class EnvironmentBase : TestFixtureAttribute
    {
        protected EnvironmentBase(Stage stage) : base(stage)
        {
            var category = stage.ToString();
            Category = category;
        }
    }
}