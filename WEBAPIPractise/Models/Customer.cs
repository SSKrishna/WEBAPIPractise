using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEBAPIPractise.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        [StringLength(10)]
        public string CustomerPhone { get; set; }

        [EmailAddressAttribute]
        public string CustomerEmail { get; set; }

        
        public string  BindingAddress { get; set; }

        [ForeignKey(nameof(Order.OrderId))]
        public long OrderId { get; set; }

    }
}
