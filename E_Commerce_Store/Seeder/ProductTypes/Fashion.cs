using E_Commerce_Store.DTO;

namespace E_Commerce_Store.Seeder.ProductTypes
{
    public static class Fashion
    {
        public static List<ProductDTO> GetFashion(int fashionCategoryId)
        {
            return new List<ProductDTO>()
            {
               new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Tommy Hoodie",
                    Description = "Comfortable and stylish hoodie from Tommy.",
                    Price = 59.99,
                    Stock = 15,
                    CategoryId = fashionCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601110/e_commerce/Fashion/tommie_hoodie_3_e3n1yl.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601108/e_commerce/Fashion/tommie_hoodie_1_jprss4.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601108/e_commerce/Fashion/tommie_hoodie_2_prd6nw.jpg",
                        }
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#FF0000", 
                            AttributeId = 1, 
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId = 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#000000",
                            AttributeId = 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "S",
                            AttributeId = 4,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "M",
                            AttributeId = 4,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "L",
                            AttributeId = 4, 
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Tommy Blouse",
                    Description = "Elegant blouse from Tommy.",
                    Price = 39.99,
                    Stock = 8,
                    CategoryId = fashionCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601107/e_commerce/Fashion/tommie_blouse_2_ejudfj.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601107/e_commerce/Fashion/tommie_blouse_1_cglmfb.webp",
                        }
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#0000FF", 
                            AttributeId = 1, 
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#FF0000",
                            AttributeId = 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId = 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "S",
                            AttributeId = 4,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "M",
                            AttributeId = 4,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "L",
                            AttributeId = 4,
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Nike Hoodie Women",
                    Description = "Stylish hoodie for women from Nike.",
                    Price = 79.99,
                    Stock = 20,
                    CategoryId = fashionCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601107/e_commerce/Fashion/nike_hoodie_w_3_s8fz3j.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601106/e_commerce/Fashion/nike_hoodie_w_2_oegvex.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601105/e_commerce/Fashion/nike_hoodie_w_1_bdc3vu.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601106/e_commerce/Fashion/nike_hoodie_w_4_gpwulc.webp",
                        }

                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#00FF00", 
                            AttributeId = 1, 
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#0000FF",
                            AttributeId = 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId = 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "S",
                            AttributeId = 4,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "M",
                            AttributeId = 4,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "L",
                            AttributeId = 4,
                        }
                        
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Nike Hoodie Men",
                    Description = "Stylish hoodie for men from Nike.",
                    Price = 79.99,
                    Stock = 20,
                    CategoryId = fashionCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601106/e_commerce/Fashion/nike_hoodie_m_2_eiajox.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601105/e_commerce/Fashion/nike_hoodie_m_3_czsfyf.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601104/e_commerce/Fashion/nike_hoodie_m_1_gl46qd.jpg",
                        }
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#000000", 
                            AttributeId = 1, 
                        },
                       
                        new ProductAttributeDTO()
                        {
                            Value = "#0000FF",
                            AttributeId = 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId = 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "S",
                            AttributeId = 4,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "M",
                            AttributeId = 4,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "L",
                            AttributeId = 4,
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Nike Backpack",
                    Description = "Spacious and durable backpack from Nike.",
                    Price = 49.99,
                    Stock = 5,
                    CategoryId = fashionCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601105/e_commerce/Fashion/nike_backpack_3_bazrym.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601104/e_commerce/Fashion/nike_backpack_1_ua8i95.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601103/e_commerce/Fashion/nike_backpack_2_lx1mbw.webp",
                        }
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#808080", 
                            AttributeId = 1, 
                        },
                         new ProductAttributeDTO()
                        {
                            Value = "#000000",
                            AttributeId = 1,
                        },

                        new ProductAttributeDTO()
                        {
                            Value = "#0000FF",
                            AttributeId = 1,
                        }

                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Nike AirMax",
                    Description = "Comfortable and stylish sneakers from Nike.",
                    Price = 129.99,
                    Stock = 10,
                    CategoryId = fashionCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601103/e_commerce/Fashion/nike_air_max_4_aiwbyu.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601103/e_commerce/Fashion/nike_air_max_3_z5d5xl.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601102/e_commerce/Fashion/nike_air_max_2_yl4z74.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601102/e_commerce/Fashion/nike_air_max_1_ak54j3.webp",
                        }
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF", 
                            AttributeId = 1, 
                        },
                       new ProductAttributeDTO()
                        {
                            Value = "#808080",
                            AttributeId = 1,
                        },
                         new ProductAttributeDTO()
                        {
                            Value = "#000000",
                            AttributeId = 1,
                        },
                         new ProductAttributeDTO()
                        {
                            Value = "9",
                            AttributeId = 4, // Size
                        },
                         new ProductAttributeDTO()
                        {
                            Value = "10",
                            AttributeId = 4, // Size
                        },
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Adidas Womens Shirt",
                    Description = "Stylish shirt for women from Adidas.",
                    Price = 29.99,
                    Stock = 18,
                    CategoryId = fashionCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601102/e_commerce/Fashion/adidas_women_shirt_4_ecnylx.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601101/e_commerce/Fashion/adidas_women_shirt_3_y5os5f.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601101/e_commerce/Fashion/adidas_women_shirt_2_gkxmkk.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601101/e_commerce/Fashion/adidas_women_shirt_1_kdi96o.webp",
                        }
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#FFC0CB", 
                            AttributeId = 1, 
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId = 1,
                        },
                       new ProductAttributeDTO()
                        {
                            Value = "#808080",
                            AttributeId = 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "S",
                            AttributeId = 4,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "M",
                            AttributeId = 4,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "L",
                            AttributeId = 4,
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Adidas Shoe",
                    Description = "Comfortable and stylish shoes from Adidas.",
                    Price = 89.99,
                    Stock = 9,
                    CategoryId = fashionCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601102/e_commerce/Fashion/adidas_shoe_1_zcoldh.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601101/e_commerce/Fashion/adidas_shoe_3_hh42lk.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601100/e_commerce/Fashion/adidas_shoe_2_o2ilkl.webp",
                        }
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#000000", 
                            AttributeId = 1, 
                        },
                         new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF", 
                            AttributeId = 1, 
                        },
                         new ProductAttributeDTO()
                        {
                            Value = "9",
                            AttributeId = 4, 
                        },
                         new ProductAttributeDTO()
                        {
                            Value = "10",
                            AttributeId = 4, 
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "10",
                            AttributeId = 4, 
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Adidas Pants",
                    Description = "Stylish pants from Adidas.",
                    Price = 49.99,
                    Stock = 13,
                    CategoryId = fashionCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601098/e_commerce/Fashion/adidas_pants_m_1_fmrrau.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601100/e_commerce/Fashion/adidas_pants_m_4_wfm7kk.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601100/e_commerce/Fashion/adidas_pants_m_3_rzoncj.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601100/e_commerce/Fashion/adidas_pants_m_2_pey9dk.webp",
                        }
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#008000", 
                            AttributeId = 1, 
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId = 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#000000",
                            AttributeId = 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "S",
                            AttributeId = 4, 
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "M",
                            AttributeId = 4, 
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "L",
                            AttributeId = 4, 
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Adidas Dress Women",
                    Description = "Elegant dress for women from Adidas.",
                    Price = 79.99,
                    Stock = 7,
                    CategoryId = fashionCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601099/e_commerce/Fashion/adidas_fulldress_w_4_bbr5qu.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601098/e_commerce/Fashion/adidas_fulldress_w_3_gphxjp.webp",
                        },
                         new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601098/e_commerce/Fashion/adidas_fulldress_w_2_f0lunf.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601098/e_commerce/Fashion/adidas_fulldress_w_1_qug16j.webp",
                        }
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#ff0000",
                            AttributeId = 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#FFA500",
                            AttributeId = 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#000000", 
                            AttributeId = 1, 
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "S",
                            AttributeId = 4,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "M",
                            AttributeId = 4,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "L",
                            AttributeId = 4,
                        }
                    }
                }

            };
        }
    }
}
