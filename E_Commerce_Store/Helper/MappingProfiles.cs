using AutoMapper;
using E_Commerce_Store.DTO;
using E_Commerce_Store.Models;
using Attribute = E_Commerce_Store.Models.Attribute;

namespace E_Commerce_Store.Helper
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Image, ImageDTO>();
            CreateMap<ProductAttribute, ProductAttributeDTO>();
            CreateMap<Product, ProductDTO>();
            CreateMap<User, UserReponseDTO>();
           
            
        }
    }
}
