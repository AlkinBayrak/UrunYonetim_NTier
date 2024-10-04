using BLL.UrunYonetimi.Managers.Abstract;
using BLL.UrunYonetimi.Models;
using DAL.UrunYonetimi.Context;
using DAL.UrunYonetimi.Entities.Concrete;
using DAL.UrunYonetimi.Repositories.Abstract;
using DAL.UrunYonetimi.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UrunYonetimi.Managers.Concrete
{
    public class ProductManager : Manager<ProductModel,Product>
    {
        public ProductManager()
        {
            _repository = new ProductRepository(new ProductDbContext());
        }
    }
}
