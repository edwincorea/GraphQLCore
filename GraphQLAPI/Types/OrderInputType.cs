using GraphQL.Types;

namespace GraphQLAPI.Types
{
    public class OrderInputType : InputObjectGraphType
    {
		public OrderInputType()
		{
			Name = "OrderInput";
			Field<NonNullGraphType<StringGraphType>>("tag");
			Field<NonNullGraphType<DateGraphType>>("createdAt");
			Field<NonNullGraphType<IntGraphType>>("customerId");
        }
    }
}
