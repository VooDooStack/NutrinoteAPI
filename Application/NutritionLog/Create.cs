using MediatR;
using Persistence;

namespace Application.NutritionLog;

public abstract class Create
{
    public class Command : IRequest
    {
        public Domain.NutritionLog Nutrition { get; init; }
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
            _context.NutritionLog.Add(request.Nutrition);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}