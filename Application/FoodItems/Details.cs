using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.FoodItems
{
    public class Details
    {
        public class Command : IRequest<FoodItem>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command, FoodItem>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<FoodItem> Handle(Command request, CancellationToken cancellationToken)
            {
                return await _context.FoodItems.FindAsync(request.Id);
            }
        }
    }
}