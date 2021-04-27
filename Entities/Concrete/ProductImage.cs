using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductImage:IEntity
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }

        public ProductImage()
        {
            Date = DateTime.Now;
        }
    }
}
