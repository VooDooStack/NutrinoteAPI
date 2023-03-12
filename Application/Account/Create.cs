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
            if (request.AppUser.Gender == "male")
            {
                request.AppUser.Bmr = 88.362 + (13.397 * request.AppUser.Weight) + (4.799 * request.AppUser.Height) - (5.677 * request.AppUser.Height);
            }
            else
            {
                request.AppUser.Bmr = 447.593 + (9.247 *  request.AppUser.Weight) + (3.098 * request.AppUser.Height) - (4.330 * request.AppUser.Height);
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}