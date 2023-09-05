using E_Commerce_Store.Data;
using E_Commerce_Store.DTO;
using E_Commerce_Store.Models;
using Attribute = E_Commerce_Store.Models.Attribute;

namespace E_Commerce_Store.Helper
{
    public static class Converter
    {
        public static ProductDTO ConvertProduct(Product product,List<ImageDTO> imageList, List<ProductAttributeDTO> productAttributes)
        {
            return new()
            {
                Id= product.Id,
                Name= product.Name,
                CategoryId= product.CategoryId,
                Description= product.Description,
                Price = product.Price,
                Stock = product.Stock,
                ImageList= imageList,
                ProductAttributes= productAttributes,
               
            };
        }
        public static ProductUsertDTO GetProductClient(Product product, List<ImageDTO> imageList, List<ProductAttributeDTO> productAttributes, List<Attribute> attributes)
        {
            return new ProductUsertDTO
            {
                Id = product.Id,
                Name = product.Name,
                CategoryId = product.CategoryId,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
                ImageList = imageList,
                Attributes = GetAttributes(productAttributes, attributes)
            };
        }


        private static Dictionary<string, List<string>> GetAttributes(List<ProductAttributeDTO> productAttributes, List<Attribute> attributeList)
        {
            var attributes = new Dictionary<string, List<string>>();

            foreach (var attribute in attributeList)
            {
                // Check if the attribute has any corresponding product attributes
                var correspondingAttributes = productAttributes
                    .Where(pa => pa.AttributeId == attribute.Id)
                    .ToList();

                if (correspondingAttributes.Count > 0)
                {
                    // Get the attribute values
                    var attributeValues = correspondingAttributes
                        .Select(pa => pa.Value)
                        .ToList();

                    attributes.Add(attribute.Name, attributeValues);
                }
            }

            return attributes;
        }


    }
}
