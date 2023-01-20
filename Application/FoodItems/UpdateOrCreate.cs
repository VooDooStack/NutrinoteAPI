
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.FoodItems
{
    public class UpdateOrCreate
    {
        public class Command : IRequest
        {
            public FoodItem FoodItem { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;

            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                FoodItem foodItem = await _context.FoodItems.FindAsync(request.FoodItem.Id);

                if (foodItem == null) _context.FoodItems.Add(request.FoodItem);

                else _mapper.Map(request.FoodItem, foodItem);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}