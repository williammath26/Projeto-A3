using AutoMapper;

public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task AddAsync(CreateProductDto createProductDto)
        {
            var product = _mapper.Map<Product>(createProductDto);
            await _productRepository.AddAsync(product);
        }

        public async Task UpdateAsync(int id, CreateProductDto updateProductDto)
        {
            var product = _mapper.Map<Product>(updateProductDto);
            product.Id = id;
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }
    }