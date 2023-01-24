using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Products;

public class Edit
{
    public class Command : IRequest
    {
        public Product Product { get; init; }
    }
    
    public  class Handler : IRequestHandler<Command>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public Handler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FindAsync(request.Product.Id);
           
            _mapper.Map(request.Product, product);

            await _context.SaveChangesAsync(cancellationToken);
            
            return Unit.Value;
        }
    }
}