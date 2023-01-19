using Domain;
using MediatR;

namespace API.Controllers.products
{
    public abstract class List
    {
        private abstract class Query : IRequest<List<Product>>
        {
        }

        public class Handler : IRequestHandler<Query, List<Product>>
        {

        }
    }

    public interface IRequestHandler<T1, T2>
    {
    }
}