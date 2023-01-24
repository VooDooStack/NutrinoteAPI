using Domain;
using MediatR;
using Persistence;

namespace Application.Products;

public abstract class Details
{
    public class Query : IRequest<Product>
    {
        public Guid Id { get; init; }
    }
    
    public class Handler : IRequestHandler<Query, Product>
    {
        private readonly DataContext _context;
        public Handler(DataContext context)
        {
            _context = context;
        }
        
        public async Task<Product> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _context.Products.FindAsync(new object[] { request.Id }, cancellationToken: cancellationToken) ?? throw new Exception("Could not find product");
        }
    }
}