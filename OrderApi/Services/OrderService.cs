using OrderApi.Repositories;
using OrderApi.Models;
namespace OrderApi.Services;

// class for all business logic regarding orders
public class OrderService
{
  private OrderRepository _repository;

  public OrderService(OrderRepository repository)
  {
    _repository = repository;
  }

  public Order Create(Order order)
  {
    return _repository.Create(order);
  }

  public ICollection<Order> List()
  {
    return _repository.List();
  }
}
