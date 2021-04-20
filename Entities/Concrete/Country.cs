using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Country:IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDaete { get; set; }
        public bool Active { get; set; }
    }
}
