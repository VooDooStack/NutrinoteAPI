using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Account;

public class Details
{
    public class Query : IRequest<AppUser>
    {
        public string Id { get; init; }
    }

    public class Handler : IRequestHandler<Query, AppUser>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public Handler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper; 
        }

        public async Task<AppUser> Handle(Query request, CancellationToken cancellationToken)
        {
            var user = await _context.AppUsers
                .Include(x => x.NutritionLogs)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.Nutrients)
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken: cancellationToken);

            return user; 
        }
    }
}