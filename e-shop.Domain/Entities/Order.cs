using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using e_shop.Domain.Entities.Customers;

namespace eShopNew.Entities;

public class Order
{
    public Order()
    {
        OrderItems = new List<OrderItem>();
    }

    [Key]
    [MaxLength(50)]
    public string Id { get; set; }

    public int? CouponId { get; set; }

    public virtual Coupon Coupon { get; set; }

    public int CustomerId { get; set; }

    public Customer Customer { get; set; }

    public int? OrderStatusId { get; set; }

    public virtual OrderStatus OrderStatus { get; set; }

    public DateTime? OrderApprovedAt { get; set; }

    public DateTime? OrderDeliveredCarrierDate { get; set; }

    public DateTime? OrderDeliveredCustomerDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; }
}