using AutoMapper;
using Product = Domain.Product;

namespace Application.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Product, Product>();
    }
}