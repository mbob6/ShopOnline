using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ShopOnline.Api.Repositories.Contracts;
using ShopOnline.Models;

namespace ShopOnline.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductRepository productRepository;
    public ProductController(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
    {
        try
        {
            var products = await this.productRepository.GetItems();
            var productCategories = await this.productRepository.GetCategories();

            if (products == null || productCategories == null)      
            {
                return NotFound();
            }
            else
            {
                var pro
            }
        }
        catch (Exception)
        {
            
            throw;
        } ;
    } 
}
