using Domain;
using MediatR;
using Persistence;

namespace Application.Account;

public class Create
{
    public class Command : IRequest
    {
        public AppUser AppUser { get; init; }
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
            _context.AppUsers.Add(request.AppUser);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}