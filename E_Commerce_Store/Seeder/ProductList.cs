using E_Commerce_Store.DTO;
using E_Commerce_Store.Seeder.ProductTypes;

namespace E_Commerce_Store.Seeder
{
    public static class ProductList
    {
        public static List<ProductDTO> GetProducts()
        {
            List<ProductDTO> electronicsList = Electronics.GetElectronics(1);
            List<ProductDTO> fashionList = Fashion.GetFashion(2);
            List<ProductDTO> toysList = Toys.GetToys(3);
            List<ProductDTO> gamingList = Gaming.GetGaming(4);
            List<ProductDTO> mangaList = Manga.GetManga(5);

            List<ProductDTO> combinedProducts = electronicsList.Concat(fashionList).Concat(toysList).Concat(gamingList).Concat(mangaList).ToList();
            
            return combinedProducts;


        }
        
    }
}
