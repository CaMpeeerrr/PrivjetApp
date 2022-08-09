using API.Models;

namespace API.Services
{
    public interface IShopService
    {
        Task<List<ShopModel>> List();
    }
}
