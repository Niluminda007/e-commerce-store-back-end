using E_Commerce_Store.DTO;

namespace E_Commerce_Store.Seeder.ProductTypes
{
    public static class Electronics
    {
        public static List<ProductDTO> GetElectronics(int electronicsCategoryId)
        {
            return new List<ProductDTO>()
            {
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Xbox 360",
                    Description = "This pre-owned or refurbished product has been professionally inspected and tested to work and look like new.",
                    Price = 375.5,
                    Stock = 10,
                    CategoryId = electronicsCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601115/e_commerce/Electronics/xbox_360_3_donxfg.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601115/e_commerce/Electronics/xbox_360_2_luoywu.webp"
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601115/e_commerce/Electronics/xbox_360_1_phgv90.webp"
                        }
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#000000",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "256GB",
                            AttributeId= 2,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "512GB",
                            AttributeId= 2,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "1TB",
                            AttributeId= 2,
                        }
                    }

                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Sony PlayStation 4",
                    Description = "The PS5 console unleashes new gaming possibilities that you never anticipated. Experience lightning fast loading with an ultra-high speed SSD, deeper immersion with support for haptic feedback, adaptive triggers, and 3D Audio, and an all-new generation of incredible PlayStation games.",
                    Price = 499.99,
                    Stock = 12,
                    CategoryId = electronicsCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601115/e_commerce/Electronics/sony_playstation5_pro_3_u5rvyu.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601115/e_commerce/Electronics/sony_playstation5_pro_2_bvflxo.webp"
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601115/e_commerce/Electronics/sony_playstation5_pro_1_wrh8zf.webp"
                        }
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#000000",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#333333",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "256GB",
                            AttributeId= 2,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "512GB",
                            AttributeId= 2,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "1TB",
                            AttributeId= 2,
                        }
                    }

                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Samsung Galaxy S23",
                    Description = "S Series has a legacy of pushing the boundaries of what a smartphone can do. And with Galaxy S23 Ultra, we’re raising that bar again. Galaxy S23 Ultra is more than the next big step in mobile tech. With the highest camera resolution on a phone and stunning Night Mode powered by Nightography, you can share those big moments no matter the lighting. Plus, with the fastest Snapdragon processor yet, juggle high-intensity games, multiple apps or video calls with ease. Write, sketch, edit, create and share from anywhere with a built-in S Pen. And do all of the above on an incredibly large display built for gaming, streaming, creating and doing. Enhance your day-to-day with a device that’s anything but ordinary and share the epic with Galaxy S23 Ultra. Whether you’re having a video meeting with your team or your friends, use Google Meet to start a video chat on your Tab** and then continue the call on your phone as you head out the door. *Based on average battery life under typical usage conditions. Average expected performance based on typical use. Actual battery life depends on factors such as network, features selected, frequency of calls, and voice, data, and other application usage patterns. Results may vary. **Requires devices to have One UI 2.5 or later. Must be logged into the same Google account and Google Meet app must be activated on each device.",
                    Price = 1154,
                    Stock = 5,
                    CategoryId = electronicsCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601114/e_commerce/Electronics/samsung_s23_2_i1jzf4.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601114/e_commerce/Electronics/samsung_s23_3_ygwlgj.webp"
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601113/e_commerce/Electronics/samsung_s23_1_lfahjc.webp"
                        }
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#000000",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#333333",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "256GB",
                            AttributeId= 2,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "512GB",
                            AttributeId= 2,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "1TB",
                            AttributeId= 2,
                        }
                    }

                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "IPhone 14 Pro",
                    Description = "The iPhone 14 models come in blue, purple, midnight, starlight, and (PRODUCT)RED, plus Apple added a new yellow color that was recently released in March. The iPhone 14 is equipped with a 6.1-inch OLED display and Apple's improved Bionic A15 processor. On the back there is a Dual camera setup with 12MP main camera and 12MP Ultra-wide sensor.",
                    Price = 998.99,
                    Stock = 3,
                    CategoryId = electronicsCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601111/e_commerce/Electronics/iphone_2_d2gwa6.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601112/e_commerce/Electronics/iphone_3_ehlnla.webp"
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601112/e_commerce/Electronics/iphone_4_rxtqjo.webp"
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601115/e_commerce/Electronics/iphone_1_z34air.jpg"
                        }
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#111111",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#F3F3F4",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#0C82F8",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#F672AC",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#FF3B30",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "256GB",
                            AttributeId= 2,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "512GB",
                            AttributeId= 2,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "1TB",
                            AttributeId= 2,
                        }
                    }

                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Galaxy Watch 5",
                    Description = "Galaxy Watch5 Pro is our most advanced outdoor watch yet, featuring a 2x stronger***** sapphire crystal glass display.\r\n\r\n*Requires smartphone with Android 8.0 or later, 1.5GB or more RAM and Samsung Health app (free) version 6.22 or later. Not intended to diagnose or treat medical conditions. For sleep pattern results, user must wear watch while they sleep for at least 7 nights and complete a survey. **The Samsung BIA is a body analyzer that uses bioelectrical impedance analysis (BIA) technology to track body composition based on weight, body fat, body mass index (BMI), skeletal muscle, body water, and basal metabolic rate (BMR) measurements. It is not intended to specifically diagnose or treat a medical condition. Requires smartphone with Android 8.0 or later, 1.5GB or more RAM and Samsung Health app (free) version 6.22 or later. ***The heart rate software functions are not intended for use in the diagnosis of disease or other conditions, or in the cure, mitigation, treatment or prevention of disease. Requires Galaxy smartphone with Android 8.0 or later, 1.5GB RAM or more and the latest version of the Samsung Health Monitor app (available only at the Samsung Galaxy app store). ****Consistent with IP68 rating, water-resistant in up to 5 feet of water for up to 30 minutes. Rinse residue / dry after wet. Requires smartphone with Android 8.0 or later, 1.5GB or more RAM and Samsung Health app (free) version 6.22 or later. *****As compared to all watches in Galaxy Watch4 Series. ******Compatibility for Galaxy wearable apps: Android 8.0 or later, 1.5GB of RAM. *******GPS Route Tracking requires import of GPX map file for hiking or cycling from third party source into Samsung Health app. GPS accuracy may be affected by weather, atmosphere and other obstructions such as buildings and tall trees. Track Back feature leads back to the start of trail for hiking or cycling. Option is only available if you have tracked your route.\r\n\r\n.",
                    Price = 399.00,
                    Stock = 21,
                    CategoryId = electronicsCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601115/e_commerce/Electronics/samsung_watch_2_pof4yk.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601114/e_commerce/Electronics/samsung_watch_3_gmajks.webp"
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601114/e_commerce/Electronics/samsung_watch_1_wth7pk.webp"
                        }
                       
                    },
                    ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#000000",
                            AttributeId= 1,
                        }
                    }

                },
                new ProductDTO()
                {
                   Id = Guid.NewGuid(),
                   Name = "Marshall HeadPhone",
                   Description = "Meet Major IV, the iconic headphones from Marshall with 80+ solid hours of wireless playtime, wireless charging and a new, improved ergonomic design. With more than three full days of power, you can stop worrying about your headphones dying on you when you need them. Over 55 years of knowledge is packed into Major IV for an explosive sound. Custom-tuned dynamic drivers deliver roaring bass, smooth mids and brilliant treble for a rich, unrivalled sound that you’ll never want to turn off.When you’re deep diving into your music, Major IV will make sure the tenth hour is as comfortable as the first. Major IV’s ear cushions are softer to the touch and more faithfully fit the shape of your ear, rendering the headphones more comfortable and wearable over time. The addition of wireless charging makes it even easier to charge and go – no more hunting for your charging cable in a mess of wires. Major IV combines enhanced usability with classic Marshall elements like the multi-directional control knob for controlling your music and phone, textured black vinyl and the Marshall script for an overall design that is both iconic and innovative",
                   Price = 149.5,
                   Stock = 16,
                   CategoryId = electronicsCategoryId,
                   ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601114/e_commerce/Electronics/marshall_headphone_3_s6t2ys.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601113/e_commerce/Electronics/marshall_headphone_4_gxn6tm.webp"
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601113/e_commerce/Electronics/marshall_headphone_1_oymtfk.webp"
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601113/e_commerce/Electronics/marshall_headphone_2_hea0uk.jpg"
                        }

                    },
                   ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#000000",
                            AttributeId= 1,
                        }
                    }

                },
                new ProductDTO()
                {
                   Id = Guid.NewGuid(),
                   Name = "Apple MacBook Pro",
                   Description = "Key Features Apple M1 Pro 10-Core Chip 16GB Unified RAM | 1TB SSD 14.2\" 3024 x 1964 Liquid Retina XDR Screen 16-Core GPU | 16-Core Neural Engine Wi-Fi 6 (802.11ax) | Bluetooth 5.0 Thunderbolt 4 | HDMI | MagSafe 3 SDXC Slot | FaceTime HD 1080p Camera Backlit Magic Keyboard Force Touch Trackpad | Touch ID Sensor",
                   Price = 1699.5,
                   Stock = 12,
                   CategoryId = electronicsCategoryId,
                   ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601113/e_commerce/Electronics/macbook_3_iufryc.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601113/e_commerce/Electronics/macbook_2_ppecq8.webp"
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601112/e_commerce/Electronics/macbook_1_zxiori.webp"

                        }
                    },
                   ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#000000",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#E8E9E9",
                            AttributeId= 1,
                        },
                         new ProductAttributeDTO()
                        {
                            Value = "512GB",
                            AttributeId= 2,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "1TB",
                            AttributeId= 2,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "2TB",
                            AttributeId= 2
                        },
                         new ProductAttributeDTO()
                        {
                            Value = "16GB",
                            AttributeId= 3,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "32GB",
                            AttributeId= 3,
                        },
                        
                    }

                },
                new ProductDTO()
                {
                   Id = Guid.NewGuid(),
                   Name = "JBL Boom Box",
                   Description = "We just made our most powerful portable Bluetooth speaker even better. The iconic silhouette of the JBL Boombox 3 has a bold new update featuring a sturdy metal handle with silicone grips, twin sidecaps, and waterproof and dustproof signature fabric. It’s been redesigned inside too, added with a new subwoofer unleashing much deeper bass and massive JBL Original Pro Sound, all with lower distortion. And 24 hours of play time takes you all the way from your morning workout to a late-night hang with your friends. And for sound that’s practically limitless, instantly connect multiple speakers with the JBL Portable app.",
                   Price = 399.9,
                   Stock = 5,
                   CategoryId = electronicsCategoryId,
                   ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601112/e_commerce/Electronics/jblboombox_1_v9cruw.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601112/e_commerce/Electronics/jblboombox_2_sxpw1y.webp"
                        }
                    },
                   ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#E8E9E9",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#0C82F8",
                            AttributeId= 1,
                        },
                         new ProductAttributeDTO()
                        {
                            Value = "#FF3B30",
                            AttributeId= 1,
                        }

                    }

                },
                new ProductDTO()
                {
                   Id = Guid.NewGuid(),
                   Name = "Asus Rog Monitor",
                   Description = "The 32” ROG Strix XG32UQ is a 4K UHD IPS professional gaming monitor designed for 160Hz (OC) gaming. It features the latest HDMI® 2.1 to support up to 4K 120Hz visuals on the latest consoles without subsampling and NVIDIA® G-SYNC® Compatible enables supersmooth experiences on PCs.",
                   Price = 752.9,
                   Stock = 8,
                   CategoryId = electronicsCategoryId,
                   ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601111/e_commerce/Electronics/asus_rog_monitor_2_hviqtc.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601111/e_commerce/Electronics/asus_rog_monitor_1_gotcma.webp"
                        }
                    },
                   ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#000000",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "200Hz",
                            AttributeId= 5,
                        },
                         new ProductAttributeDTO()
                        {
                            Value = "400Hz",
                            AttributeId= 5,
                        }

                    }

                },
                 new ProductDTO()
                {
                   Id = Guid.NewGuid(),
                   Name = "Asus Rog Strix G16",
                   Description = "Raise your game and carry your squad with the new ROG Strix G16, a powerful gaming laptop that features Windows 11, a 13th Gen Intel Core processor, and an NVIDIA GeForce RTX 40 Series Laptop GPU. With DDR5-4800MHz memory and PCIe 4x4, this laptop is designed to provide lightning-fast performance and minimize loading times. The ROG Intelligent Cooling system with upgraded liquid metal on the CPU and Tri-Fan Technology, ensures that the laptop can handle the power it can deliver. The fast FHD 165Hz panel makes sure you never miss a moment, and the MUX Switch with Advanced Optimus optimizes both gaming performance and battery life. The laptop's design is inspired by cyberpunk aesthetics and graffiti accents, and features unique elements such as a dot matrix design on the lid and cross-hatched vents.",
                   Price = 1299,
                   Stock = 3,
                   CategoryId = electronicsCategoryId,
                   ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601111/e_commerce/Electronics/asus_strix_1_irasnc.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601111/e_commerce/Electronics/asus_strix_2_bbuevp.webp"
                        }
                    },
                   ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "1TB",
                            AttributeId= 2,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "2TB",
                            AttributeId= 2,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "16GB",
                            AttributeId= 3,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "32GB",
                            AttributeId= 3,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "240Hz",
                            AttributeId= 5,
                        },
                         new ProductAttributeDTO()
                        {
                            Value = "360Hz",
                            AttributeId= 5,
                        }

                    }

                },
                 new ProductDTO()
                {
                   Id = Guid.NewGuid(),
                   Name = "AirPods Pro",
                   Description = "AirPods Pro feature up to 2x more Active Noise Cancellation, plus Adaptive Transparency, and Personalized Spatial Audio with dynamic head tracking for immersive sound. Now with multiple ear tips (XS, S, M, L) and up to 6 hours of listening time.",
                   Price = 189.99,
                   Stock = 6,
                   CategoryId = electronicsCategoryId,
                   ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601111/e_commerce/Electronics/apple_airpods_2_piugvs.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601111/e_commerce/Electronics/apple_airpods_1_qelhed.webp"
                        }
                    },
                   ProductAttributes = new List<ProductAttributeDTO>()
                    {
                        new ProductAttributeDTO()
                        {
                            Value = "#FFFFFF",
                            AttributeId= 1,
                        },
                        new ProductAttributeDTO()
                        {
                            Value = "#000000",
                            AttributeId= 1,
                        }

                    }

                }
            };
        }
    }
}
