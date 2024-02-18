using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEBAPIPractise.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey(nameof(Product.ProductId))]
        public long ProductId { get; set; }

        public int Quantity { get; set; }


    }
}
