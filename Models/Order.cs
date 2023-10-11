namespace OrderApi.Models;

public class Order
{
  public string? Id { get; set; }

  public string? CustomerId { get; set; }

  public OrderStatus? Status { get; set; }

  // TODO: Don't know if the ORM will allow for this
  public ICollection<string>? OrderProductIDs { get; set; }
}

public enum OrderStatus
{
  Open,
  Fulfilled,
  Cancelled,
}
