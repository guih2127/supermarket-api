using AutoMapper;
using supermarket_api.Domain.Models;
using supermarket_api.Resources;

namespace supermarket_api.Extensions
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}