using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Core.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ILogger<ProductsController> _logger;
    private readonly IGenericRepository<Product> _productsRepo;
    private readonly IGenericRepository<ProductBrand> _productBrandRepo;
    private readonly IGenericRepository<ProductType> _productTypeRepo;

    public ProductsController(ILogger<ProductsController> logger, IGenericRepository<Product> productsRepo,
    IGenericRepository<ProductBrand> productBrandRepo, IGenericRepository<ProductType> productTypeRepo
    )
    {
        _productTypeRepo = productTypeRepo;
        _productBrandRepo = productBrandRepo;
        _logger = logger;
        _productsRepo = productsRepo;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts()
    {
        var products = await _productsRepo.ListAllAsync();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        var product = await _productsRepo.GetByIdAsync(id);
        return product;
    }

    [HttpGet("brands")]
    public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetBrands()
    {
        return Ok(await _productBrandRepo.ListAllAsync());
    }

    [HttpGet("types")]
    public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetTypes()
    {
        return Ok(await _productTypeRepo.ListAllAsync());
    }
}
