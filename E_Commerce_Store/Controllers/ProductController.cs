using AutoMapper;
using E_Commerce_Store.DTO;
using E_Commerce_Store.Helper;
using E_Commerce_Store.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Store.Controllers
{
    [Authorize(Roles = "user,admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IImageRepository _imageRepository;
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly IAttributeRepository _attributeRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository, IImageRepository imageRepository, IProductAttributeRepository productAttributeRepository, IAttributeRepository attributeRepository,
             IMapper mapper)
        {
            _productRepository = productRepository;
            _imageRepository = imageRepository;
            _productAttributeRepository = productAttributeRepository;
            _attributeRepository = attributeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ProductDTO>))]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productRepository.GetProducts();

            var productDTOs = new List<ProductDTO>();

            foreach (var product in products)
            {
                List<ImageDTO> images = _mapper.Map<List<ImageDTO>>(await _imageRepository.GetImages(product.Id));
                List<ProductAttributeDTO> productAttributes = _mapper.Map<List<ProductAttributeDTO>>(await _productAttributeRepository.GetProductAttributes(product.Id));
                ProductDTO productDTO = Converter.ConvertProduct(product, images, productAttributes);
                productDTOs.Add(productDTO);
            }
            return Ok(productDTOs);
        }
        [HttpGet("{productId}")]
        [ProducesResponseType(200, Type = typeof(ProductDTO))]
        public async Task<IActionResult> GetProduct(Guid productId)
        {
            if (!await _productRepository.ProductExits(productId))
                return NotFound();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _productRepository.GetProduct(productId);
            List<ImageDTO> images = _mapper.Map<List<ImageDTO>>(await _imageRepository.GetImages(product.Id));
            List<ProductAttributeDTO> productAttributes = _mapper.Map<List<ProductAttributeDTO>>(await _productAttributeRepository.GetProductAttributes(product.Id));
            ProductDTO productDTO = Converter.ConvertProduct(product, images, productAttributes);

            return Ok(productDTO);
        }

        [HttpPost("search")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ProductDTO>))]
        public async Task<IActionResult> SearchProducts([FromBody] ProductSearchRequestDTO searchRequest)
        {
            if (string.IsNullOrEmpty(searchRequest.Keyword))
            {
                return BadRequest("Keyword cannot be empty.");
            }

            var products = await _productRepository.SearchProducts(searchRequest.Keyword);
            var productDTOs = new List<ProductDTO>();

            foreach (var product in products)
            {
                List<ImageDTO> images = _mapper.Map<List<ImageDTO>>(await _imageRepository.GetImages(product.Id));
                List<ProductAttributeDTO> productAttributes = _mapper.Map<List<ProductAttributeDTO>>(await _productAttributeRepository.GetProductAttributes(product.Id));
                ProductDTO productDTO = Converter.ConvertProduct(product, images, productAttributes);
                productDTOs.Add(productDTO);
            }

            return Ok(productDTOs);
        }
    }
}
