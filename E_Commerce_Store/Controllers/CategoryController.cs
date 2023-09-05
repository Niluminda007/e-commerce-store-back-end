using AutoMapper;
using E_Commerce_Store.DTO;
using E_Commerce_Store.Helper;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using E_Commerce_Store.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Attribute = E_Commerce_Store.Models.Attribute;

namespace E_Commerce_Store.Controllers
{
    [Authorize(Roles = "user,admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IImageRepository _imageRepository;
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly IAttributeRepository _attributeRepository;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryRepository categoryRepository,IImageRepository imageRepository, IProductAttributeRepository productAttributeRepository, IAttributeRepository attributeRepository,
             IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _imageRepository = imageRepository;
            _productAttributeRepository = productAttributeRepository;
            _attributeRepository = attributeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200,Type = typeof(IEnumerable<Category>))]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryRepository.GetCategories();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
     
            return Ok(categories);
        }

        [HttpGet("{categoryId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ProductUsertDTO>))]
        public async Task<IActionResult> GetProductsByCategory(int categoryId)
        {
            if (!await _categoryRepository.CategoryExists(categoryId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var products = await _categoryRepository.GetProductsByCategory(categoryId);

            List<ProductUsertDTO> productDTOs = new List<ProductUsertDTO>();

            foreach (var product in products)
            {
                List<Attribute> attributes= await  _attributeRepository.GetAttributes();
                List<ImageDTO> imageList = _mapper.Map<List<ImageDTO>>(await _imageRepository.GetImages(product.Id));
                List<ProductAttributeDTO> productAttributes = _mapper.Map<List<ProductAttributeDTO>>(await _productAttributeRepository.GetProductAttributes(product.Id));

                ProductUsertDTO productDTO = Converter.GetProductClient(product, imageList, productAttributes, attributes);
                productDTOs.Add(productDTO);
            }

            return Ok(productDTOs);
        }
    }
}
