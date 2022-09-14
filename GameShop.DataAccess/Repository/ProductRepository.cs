using GameShop.DataAccess.Repository.IRepository;
using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(x => x.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.Description = obj.Description;
                objFromDb.Price = obj.Price;

                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.Price50 = obj.Price50;
                objFromDb.Producent = obj.Producent;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.CoverTypeId = obj.CoverTypeId;

                objFromDb.Price100 = obj.Price100;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }


    }
}
