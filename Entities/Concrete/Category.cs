using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public short CategoryId { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
    }
}
