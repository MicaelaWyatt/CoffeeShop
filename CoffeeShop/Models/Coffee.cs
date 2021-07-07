using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Coffee: BeanVariety
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BeanVarietyId { get; set; }
    }
}
