using ShopOnline.Models.Dtos;

namespace ShopOnline.Web;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetItems();
}
