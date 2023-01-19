using MediatR;
using Persistence;

namespace Application.Products;

public abstract class Delete
{
    public class Command : IRequest
    {
        public Guid Id { get; set; }
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
            var product = await _context.Products.FindAsync(new object[] { request.Id }, cancellationToken: cancellationToken);
            
            if (product == null)
                throw new Exception("Could not find product");
            
            _context.Remove(product);
            
            var success = await _context.SaveChangesAsync(cancellationToken) > 0;
            
            if (success) return Unit.Value;
            
            throw new Exception("Problem saving changes");
        }
    }
}