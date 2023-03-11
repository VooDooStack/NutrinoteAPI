using Domain;
using MediatR;
using Persistence;

namespace Application.Products;

public abstract class Create
{
    public class Command : IRequest
    {
        public Product Product { get; init; }
    }

    public class Handler : IRequestHandler<Command>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            _context.Products.Add(request.Product);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}