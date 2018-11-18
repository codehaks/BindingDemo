using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BindingDemo.Models
{
    public class ProductInfo
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Maker Maker { get; set; }
    }
}
