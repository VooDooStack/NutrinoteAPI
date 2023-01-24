using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.FoodItems
{
    public class List
    {
        public class command : IRequest<List<FoodItem>>
        {
        }

        public class Handler : IRequestHandler<command, List<FoodItem>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<FoodItem>> Handle(command request, CancellationToken cancellationToken)
            {
                try
                {
                    return await _context.FoodItems.ToListAsync(cancellationToken);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}