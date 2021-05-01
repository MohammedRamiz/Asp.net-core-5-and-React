using App.Api.Graphql.GraphQLTypes;
using HotChocolate;
using HotChocolate.Types;
using Infrastructure.Repository.IRepository;

namespace App.Api.Graphql.Mutation
{
    [ExtendObjectType(Name = "Mutation")]
    public class UserMutations
    {
        public string Authentication([Service] IUnitOfWork unitOfWork, LoginInput inputData)
        {
            Core.Entities.User user = unitOfWork.User.Authenticate(inputData.Email, inputData.Password);
            if (user != null)
            {
                return unitOfWork.Token.CreateToken(user);
            }
            return "Invalid username";
        }
    }
}
