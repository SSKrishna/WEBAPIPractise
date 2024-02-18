using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WEBAPIPractise.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        [Precision(18,2)]
        public decimal ProductPrice { get; set; }
    }
}
