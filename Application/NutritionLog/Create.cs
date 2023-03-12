using Application.Interfaces;
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
        private readonly IUserAccessor _userAccessor;

        public Handler(DataContext context, IUserAccessor userAccessor)
        {
            _context = context;
            _userAccessor = userAccessor;
        }

        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            request.Nutrition.AppUserId = _userAccessor.getUserId();
            request.Nutrition.CreatedAt = DateTime.Now.ToUniversalTime();
            request.Nutrition.UpdatedAt = DateTime.Now.ToUniversalTime();
            _context.NutritionLog.Add(request.Nutrition);
            
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}