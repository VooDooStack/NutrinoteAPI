using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.NutritionLog;

public abstract class List
{
    public class Query : IRequest<List<Domain.NutritionLog>>
    {
        public string AppUserId { get; init; }
    }

    public class Handler : IRequestHandler<Query, List<Domain.NutritionLog>>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.NutritionLog>> Handle(Query request, CancellationToken cancellationToken)
        {
            try
            {
                return await _context.NutritionLog.Where(x => x.AppUserId == request.AppUserId)
                    .Include(x => x.Product)
                    .ThenInclude(x => x.Nutrients)
                    .ToListAsync(cancellationToken);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}