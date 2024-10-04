using DAL.UrunYonetimi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UrunYonetimi.Entities.Abstract
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime Created { get; set; }

        DateTime? ModifiedDate { get; set; }

        DateTime? DeletedDate { get; set; }

        DataStatus DataStatus { get; set; }
    }
}
