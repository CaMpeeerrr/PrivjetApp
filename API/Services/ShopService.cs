using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Services
{
    public class ShopService : IShopService 
    {
        private readonly ApplicationDbContext dbContext;

        public ShopService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<ShopModel>> List()
        {
            var shops = await (from shop in dbContext.Shop
                               select new ShopModel()
                               {
                                   Id = shop.Id,
                                   Name = shop.Names,
                                   OpeningHours = shop.OpeningHours,
                                  Address = shop.Address
                               }).ToListAsync();
            return shops;
             
            }
        }
    }

