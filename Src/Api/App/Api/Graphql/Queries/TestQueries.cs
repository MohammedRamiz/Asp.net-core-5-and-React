using HotChocolate.Types;

namespace App.Api.Graphql.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class TestQueries
    {
        public string GetTest()
        {
            return "Query Working";
        }
    }
}
