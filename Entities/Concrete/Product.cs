using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public long BrandId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
    }
}
