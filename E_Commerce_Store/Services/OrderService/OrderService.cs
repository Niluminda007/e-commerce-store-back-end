using AutoMapper;
using E_Commerce_Store.DTO;
using E_Commerce_Store.Helper;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using E_Commerce_Store.Repositories;

namespace E_Commerce_Store.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly IImageRepository _imageRepository;
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly IOrderItemRepository _oderItemRepository;
        private readonly IOrderItemProductAttributeRepository _oderItemProductRepository;
        private readonly IMapper _mapper;
        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository, IImageRepository imageRepository, IAttributeRepository attributeRepository, IProductAttributeRepository productAttributeRepository, IMapper mapper, IOrderItemRepository oderItemRepository, IOrderItemProductAttributeRepository oderItemProductRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _imageRepository = imageRepository;
            _productAttributeRepository = productAttributeRepository;
            _mapper = mapper;
            _oderItemRepository = oderItemRepository;
            _oderItemProductRepository = oderItemProductRepository;
        }

        public async Task<List<OrdersDTO>> GetCustomerOrders(int customerId)
        {
            var orders = await _orderRepository.GetCustomerOrders(customerId);
            var ordersDTO = new List<OrdersDTO>();

            if (orders != null)
            {
                foreach (var order in orders)
                {
                    var newOrderItemsDTO = await GetOrderItemsDTO(order);
                    OrdersDTO newOrder = new()
                    {
                        UserId = order.UserId,
                        OrderDate = order.OrderDate,
                        Total = order.Total,
                        OrderItems = newOrderItemsDTO
                    };

                    ordersDTO.Add(newOrder);
                }
            }

            return ordersDTO;
        }

        public async Task<List<OrderItemDTO>> GetOrderItemsDTO(Order order)
        {
            var orderItems = await _oderItemRepository.GetOrderItemsByOrder(order.Id);
            var newOrderItemsDTO = new List<OrderItemDTO>();
            if (orderItems != null)
            {
                foreach (OrderItem orderItem in orderItems)
                {
                    var product = await GetProductDTO(orderItem.ProductId);
                    OrderItemDTO newOrderItemDTO = new()
                    {
                        Id = orderItem.Id,
                        Quantity = orderItem.Quantity,
                        Amount = product.Price * orderItem.Quantity,
                        Product = product,
                        Attributes = await _oderItemProductRepository.GetOrderedItemProductAttributesByOrderItemId(orderItem)

                    };
                    newOrderItemsDTO.Add(newOrderItemDTO);
                }
            }
            return newOrderItemsDTO;
        }

        public async Task<bool> PlaceOrder(OrdersDTO order)
        {
            var orderItems = new List<OrderItem>() { };

            foreach (OrderItemDTO orderItem in order.OrderItems)
            {
                var newItem = new OrderItem()
                {
                    Quantity = orderItem.Quantity,
                    ProductId = orderItem.Product.Id,
                    OrderItemProductAttributes = await GetOrderItemProductAttributes(orderItem)

                };
                orderItems.Add(newItem);
            }

            Order newOrder = new()
            {
                OrderDate = order.OrderDate,
                Total = order.Total,
                OrderItems = orderItems,
                UserId = order.UserId,
            };
            return await _orderRepository.PlaceOrder(newOrder);
        }

        private async Task<ProductDTO> GetProductDTO(Guid productId)
        {
            var product = await _productRepository.GetProduct(productId);
            List<ImageDTO> images = _mapper.Map<List<ImageDTO>>(await _imageRepository.GetImages(product.Id));
            List<ProductAttributeDTO> productAttributes = GetProductAttributeDTO((await _productAttributeRepository.GetProductAttributes(product.Id)));
            ProductDTO productDTO = Converter.ConvertProduct(product, images, productAttributes);
            return productDTO;

        }
        private List<ProductAttributeDTO> GetProductAttributeDTO(List<ProductAttribute> productAttribute)
        {
            return _mapper.Map<List<ProductAttributeDTO>>(productAttribute);
        }
        private async Task<List<OrderItemProductAttribute>> GetOrderItemProductAttributes(OrderItemDTO orderItem)
        {
            if (orderItem.Attributes == null)
            {
                return new List<OrderItemProductAttribute>();
            }

            var orderItemAttributes = new List<OrderItemProductAttribute>();
            foreach (ProductAttributeDTO attribute in orderItem.Attributes)
            {
                var productAttribute = await _productAttributeRepository.GetProductAttributeByProdcutAttribute(orderItem.Product.Id, attribute.AttributeId, attribute.Value);
                var orderItemAttribute = new OrderItemProductAttribute()
                {
                    OrderItemId = orderItem.Id,
                    ProductAttributeId = productAttribute.Id,
                };
                orderItemAttributes.Add(orderItemAttribute);
            }
            return orderItemAttributes;
        }
    }
}
