using E_Commerce_Store.Data;
using E_Commerce_Store.DTO;
using E_Commerce_Store.Models;

using Attribute = E_Commerce_Store.Models.Attribute;

namespace E_Commerce_Store.Seeder
{
    public class Seed
    {
        private readonly DataContext dataContext;
        private List<ProductDTO> products;
        public Seed(DataContext context)
        {
            dataContext = context;
            products = ProductList.GetProducts();

        }
        public void SeedDataContext()
        {
            if(!dataContext.Products.Any())
            {
                SeedUserRoles();
                SeedUsers();
                SeedCategories();
                SeedAttributes();
                SeedProducts();
            }
        }
        
        
        private void SeedProducts()
        {
            foreach (ProductDTO product in products)
            {
                var newProduct = new Product()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Stock = product.Stock,
                    CategoryId = product.CategoryId

                };
                dataContext.Products.Add(newProduct);
                dataContext.SaveChanges();

                SeedImagesForProduct(product.Id, product.ImageList);

                var productAttributeExists = product?.ProductAttributes is not null;

                if (productAttributeExists)
                {
                    SeedProductAttribute(product.Id, product.ProductAttributes);
                }
            }
        }


        private void SeedCategories()
        {
            if(!this.dataContext.Categories.Any())
            {
                string[] categories = {"Electronics","Fashion","Toys","Gaming","Manga" };
                
                foreach(var category in categories)
                {
                    var newCategory = new Category()
                    {
                        Name = category

                    };
                    dataContext.Categories.Add(newCategory);
                    dataContext.SaveChanges();
                }
            }
        }
        private void SeedImagesForProduct(Guid productId, List<ImageDTO> imageList)
        {
            foreach(var image in imageList)
            {
                var newImage = new Image()
                {
                    Url = image.Url,
                    ProductId= productId,

                };
                dataContext.Images.Add(newImage);
                dataContext.SaveChanges();
            }
        }

        private void SeedAttributes()
        {
            if (!dataContext.Attributes.Any())
            {
                string[] attributes = { "Color", "Capacity", "RAM", "Size", "Refresh Rate" };
                
                foreach (var attribute in attributes)
                {
                    var newAttribute = new Attribute()
                    {
                        Name = attribute
                    };
                    dataContext.Attributes.Add(newAttribute);
                    dataContext.SaveChanges();
                }
            }
        }
        private void SeedProductAttribute(Guid productId, List<ProductAttributeDTO> productAttributeList)
        {

            foreach(var productAttribute in productAttributeList)
            {

                var newProductAttribute = new ProductAttribute()
                {
                    ProductId = productId,
                    AttributeId = productAttribute.AttributeId,
                    Value = productAttribute.Value
                };

                dataContext.ProdcutAttributes.Add(newProductAttribute);
                dataContext.SaveChanges();

            }
        }
        private void SeedUsers()
        {
            if(!dataContext.Users.Any())
            {
                List < User > users = new List<User>()
                {
                    new User()
                    {
                        UserName = "ushan_niluminda",
                        Password= "ushan123",
                        FullName= "ushan niluminda",
                        Email = "princeofpersiatwathrones@gmail.com",
                        Address = "Europe,Latvia",
                        UserRoleId = 2
                       

                    },
                    new User()
                    {
                        UserName = "admin",
                        Password= "admin",
                        FullName= "admin",
                        Email = "admin@gmail.com",
                        Address = "Norway",
                        UserRoleId = 1

                    }
                };
                dataContext.Users.AddRange(users);
                dataContext.SaveChanges();
            }
        }
        private void SeedUserRoles()
        {
            if (!dataContext.UserRoles.Any())
            {
                List<UserRole> userRoles = new List<UserRole>()
                {
                   new UserRole()
                  {
                      Name = "user",
                  },
                  new UserRole()
                  {
                      Name = "admin",

                  }
                };

                dataContext.UserRoles.AddRange(userRoles);
                dataContext.SaveChanges();
            }
        }
       
    }
}
