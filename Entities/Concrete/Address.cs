using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Address:IEntity
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long CityId { get; set; }
        public string AddressDetail { get; set; }
        public string PostalCode { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }

    }
}
