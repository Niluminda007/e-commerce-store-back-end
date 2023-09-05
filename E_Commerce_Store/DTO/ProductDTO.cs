﻿namespace E_Commerce_Store.DTO
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public List<ImageDTO> ImageList { get; set; }
        public List<ProductAttributeDTO> ProductAttributes { get; set; }
    }
}
