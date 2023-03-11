using AutoMapper; 
using MediatR;
using OpenFoodFacts;
using Persistence;
using Product = Domain.Product;

namespace Application.Products;

public abstract class Details
{
    public class Query : IRequest<Product>
    {
        public string Id { get; init; }
    }

    public class Handler : IRequestHandler<Query, Product>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public Handler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Product> Handle(Query request, CancellationToken cancellationToken)
        {
            try
            {
                var product = await _context.Products.FindAsync(new object[] { request.Id }, cancellationToken);
                if (product != null) return product;

                Console.WriteLine("no product found from db matching {0}; trying to get from open food facts", request.Id);

                var client = new HttpClient();
                var response = await client.GetAsync($"https://world.openfoodfacts.org/api/v2/product/{request.Id}",
                    cancellationToken);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync(cancellationToken);
                    var openFoodFact = OpenFoodFact.FromJson(content);

                    Console.WriteLine("product result {0}", openFoodFact.Product.GenericNameDe ?? "");
                    product = new Product
                    {
                        Id = openFoodFact.Product.Code ?? Guid.NewGuid().ToString(),
                        Name = openFoodFact.Product.GenericNameEn,
                        Description = openFoodFact.Product.Labels,
                        ImageThumbnailUrl = openFoodFact.Product.ImageThumbUrl,
                        Barcode = openFoodFact.Product.Code,
                        // Nutrients = _mapper.Map<Nutrients>(openFoodFact.Product.Nutriments)
                    };
                    _context.Products.Add(product);
                    await _context.SaveChangesAsync(cancellationToken);
                    return product;
                }

                Console.WriteLine("Product not found from open food facts");
                return product;
            }
            catch (Exception e)
            {
                throw new Exception("Error while searching for product", e);
            }
        }
    }
}