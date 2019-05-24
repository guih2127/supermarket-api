using AutoMapper;
using supermarket_api.Domain.Models;
using supermarket_api.Resources;
using supermarket_api.Extensions;

namespace Supermarket.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement, 
                opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));
        }
    }
}