using DAL.UrunYonetimi.Context;
using DAL.UrunYonetimi.Entities.Concrete;
using DAL.UrunYonetimi.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UrunYonetimi.Repositories.Concrete
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(ProductDbContext context) : base(context)
        {

        }
    }
}
