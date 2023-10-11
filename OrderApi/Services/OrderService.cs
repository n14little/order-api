using OrderApi.Models;
namespace OrderApi.Services;

public class OrderService
{
  private ICollection<Order> _orders = new List<Order>();

  public Order Create(Order order)
  {
    _orders.Add(order);

    return order;
  }

  public ICollection<Order> List()
  {
    return _orders;
  }
}
