using HotChocolate.Types;

namespace App.Api.Graphql.Mutation
{
    [ExtendObjectType(Name = "Mutation")]
    public class TestMutations
    {
        public string SaveTest()
        {
            return "Mutation Working";
        }
    }
}
