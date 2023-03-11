using AutoMapper;
using Domain;
using OpenFoodFacts;
using Product = Domain.Product;

namespace Application.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Product, Product>();
        CreateMap<Nutrients, Nutriments>();
    }
}