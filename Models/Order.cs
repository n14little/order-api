namespace OrderApi.Models;

public class Order
{
  public string? Id { get; set; }

  public string? CustomerId { get; set; }

  public OrderStatus? Status { get; set; }
}

public enum OrderStatus
{
  Open,
  Fulfilled,
  Cancelled,
}
